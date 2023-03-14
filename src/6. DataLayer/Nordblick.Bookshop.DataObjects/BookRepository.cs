using Dapper;
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
    public class BookRepository : IBookRepository
    {
        private readonly string _dapperConnectionString;

        public BookRepository(string connectionString)
        {
            _dapperConnectionString = connectionString;
        }

        #region Read Befehle 
        public async Task<IEnumerable<Book>> GetAll()
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryAsync<Book>("SELECT * FROM Book;");
                
                return result;
            }
        }

        public async Task<Book> Find(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryFirstOrDefaultAsync<Book>("SELECT * FROM Book WHERE Id = @id;", new { id });
                return result;
            }
        }

        public async Task<IEnumerable<Book>> GetAllByPublisherId(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryAsync<Book>("SELECT * FROM Book WHERE PublisherId = @id;", new { id });
                
                return result;
            }
        }

        public async Task<IEnumerable<Book>> GetAllByAuthorId(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryAsync<Book>("SELECT * FROM Book WHERE AuthorId = @id;", new { id });
                
                return result;
            }
            #endregion
        }
            #region Create Befehle
            public async Task<Book> Add(Book book)
            {
                using (IDbConnection context = new SqlConnection(_dapperConnectionString))
                {
                    book.CreatedOn = DateTime.Now;
                    book.ChangedOn = DateTime.Now;

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
                
                    var id = await context.QuerySingleAsync<int>(sql, book);
                    book.Id = id;

                    return book;
                }
            }

            public async Task AddGenreToBook(int bookId, int genreId)
            {
                using (IDbConnection context = new SqlConnection(_dapperConnectionString))
                {            
                    var sql = ("INSERT INTO BookGenre (BookId, GenreId)" +
                                                      " VALUES " +
                                                     "(@BookId, @GenreId);");

                   await context.ExecuteAsync(sql, new { bookId, genreId });
                }
            }
        
            public async Task AddAuthorToBook(BookAuthor bookAuthor)
            {
                using (IDbConnection context = new SqlConnection(_dapperConnectionString))
                {
                    var sql = ("INSERT INTO BookAuthor (BookId, AuthorId, IsMainAuthor)" +
                                                      " VALUES " +
                                                     "(@BookId, @AuthorId, @IsMainAuthor);");

                   await context.ExecuteAsync(sql, bookAuthor);
                }
            }
            #endregion

            #region Update Befehle
            public async Task<Book> Update(Book book)
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

                    await context.ExecuteAsync(sql, book);

                    return book;
                }
            }
            #endregion

            #region Delete Befehle
            public void Remove(int id)
            {
                using (IDbConnection context = new SqlConnection(_dapperConnectionString))
                {
                    context.Execute("DELETE FROM Book WHERE Id = @id", new { id });
                }
            }

            public Book FindJson()
            {
                throw new NotImplementedException();
            }
            #endregion

        }
    }

