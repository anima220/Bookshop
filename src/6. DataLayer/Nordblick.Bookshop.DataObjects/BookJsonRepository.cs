using Dapper;
using Newtonsoft.Json;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.DataObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects
{
    public class BookJsonRepository : IBookRepository
    {
        private readonly string _dapperConnectionString;
        private readonly string path = "C:\\Users\\fnissen\\source\\repos\\Kunden\\Nordblick\\Bookshop\\doc\\TestJson.txt";

        public BookJsonRepository(string connectionString)
        {
            _dapperConnectionString = connectionString;
        }
        private List<Book> GetBooklistFromFile(string path)
        {
            var json = File.ReadAllText(path);
            List<Book> result = JsonConvert.DeserializeObject<List<Book>>(json);

            return result;
        }

        #region Read Befehle 

        public List<Book> GetAll()
        {

            List<Book> result = GetBooklistFromFile(path);

            return result;
        }
        public Book Find(int id)
        {
            
            List<Book> BookList = GetBooklistFromFile(path);

            var result = BookList.Find(c => c.Id == id);

            return result;
        }


        public List<Book> GetAllByPublisherId(int id)
        {

            List<Book> BookList = GetBooklistFromFile(path);

            var result = BookList.FindAll(c => c.PublisherId == id);

            return result;

        }
        #endregion

        #region Create Befehle
        public Book Add(Book book)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                book.CreatedOn = DateTime.Now;
                book.ChangedOn = DateTime.Now;

                //alles auslesen und ein anhängen?

                var sql = ("INSERT INTO Book (PublisherId, Title, PublishingYear," +
                                             "PageCount, Edition, Price, AvailabilityState," +
                                             "CoverType, IsEbook, State, Isbn, CreatedOn, " +
                                             "CreatedBy, ChangedBy, ChangedOn) " +
                                             "VALUES" +
                                             "(@PublisherId, @Title, @PublishingYear," +
                                             "@PageCount, @Edition, @Price, @AvailabilityState," +
                                             "@CoverType, @IsEbook, @State, @Isbn, @CreatedOn, " +
                                             "@CreatedBy, @ChangedBy, @ChangedOn);" +
                                             "SELECT CAST (SCOPE_IDENTITY() as int)");
                var id = context.Query<int>(sql, book).SingleOrDefault();
                book.Id = id;

                return book;
            }
        }

        public void AddGenreToBook(int bookId,int genreId)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {


                var sql = ("INSERT INTO BookGenre (BookId, GenreId)" +
                                                  " VALUES " +
                                                 "(@BookId, @GenreId);");

                context.Execute(sql, new {bookId, genreId});    
            }
        }

        public void AddAuthorToBook(BookAuthor bookAuthor)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var sql = ("INSERT INTO BookAuthor (BookId, AuthorId, IsMainAuthor)" +
                                                  " VALUES " +
                                                 "(@BookId, @AuthorId, @IsMainAuthor);");

                context.Execute(sql, bookAuthor);
            }
        }
        #endregion

        #region Update Befehle
        public Book Update(Book book)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                book.ChangedOn = DateTime.Now;

                var sql = "UPDATE Book SET PublisherId = @PublisherId," +
                                          "Title = @Title," +
                                          "PublishingYear = @PublishingYear," +
                                          "PageCount = @PageCount," +
                                          "Edition = @Edition," +
                                          "Price = @Price," +
                                          "AvailabilityState = @AvailabilityState," +
                                          "CoverType = @CoverType," +
                                          "IsEbook = @IsEbook," +
                                          "State = @State," +
                                          "Isbn = @Isbn," +
                                          "CreatedOn = @CreatedOn," +
                                          "CreatedBy = @CreatedBy," +
                                          " ChangedBy = @ChangedBy," +
                                          " ChangedOn = @ChangedOn;";

                context.Execute(sql, book);

                return book;
            }
        }
        #endregion

        #region Delete Befehle
        public void Remove(int id)
        {

            //alles auslesen und spezifische irgendwie löschen
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                context.Execute("DELETE FROM Book WHERE Id = @id", new { id });
            }
        }

        public List<Book> GetAllByAuthorId(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
