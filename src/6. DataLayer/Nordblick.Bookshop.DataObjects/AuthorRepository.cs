using Dapper;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.DataObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly string _dapperConnectionString;

        public AuthorRepository(string connectionString)
        {
            _dapperConnectionString = connectionString;
        }

        #region Read Befehle 
        public async Task<IEnumerable<Author>> GetAll()
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryAsync<Author>("SELECT * FROM Author;");
                
                return result;
            }
        }
        public async Task<Author> Find(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryFirstOrDefaultAsync<Author>("SELECT * FROM Author WHERE Id = @id;", new { id });
                
                return result;
            }
        }

        #endregion

        #region Create Befehle
        public async Task<Author> Add(Author author)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                author.CreatedOn = DateTime.Now;
                author.ChangedOn = DateTime.Now;

                var sql = ("INSERT INTO Author (PublisherId, FirstName, LastName," +
                                               "BirthDate, IsAlive, BookCount, State," +
                                               "CreatedOn, CreatedBy, ChangedBy, ChangedOn) " +
                                               "VALUES" +
                                               "(@PublisherId, @FirstName, @LastName," +
                                               "@BirthDate, @IsAlive, @BookCount, @State," +
                                               "@CreatedOn, @CreatedBy, @ChangedBy, @ChangedOn);" +
                                               "SELECT CAST (SCOPE_IDENTITY() as int)");
                var id = await context.QuerySingleAsync<int>(sql, author);
                author.Id = id;

                return author;
            }
        }
        #endregion

        #region Update Befehle
        public async Task<Author> Update(Author author)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                author.ChangedOn = DateTime.Now;

                var sql = "UPDATE author SET PublisherId = @PublisherId," +
                                            "FirstName = @FirstName," +
                                            "LastName = @LastName," +
                                            "BirthDate = @BirthDate," +
                                            "IsAlive = @IsAlive," +
                                            "BookCount = @BookCount," +
                                            "State = @State," +
                                            "CreatedOn = @CreatedOn," +
                                            "CreatedBy = @CreatedBy," +
                                            "ChangedBy = @ChangedBy," +
                                            "ChangedOn = @ChangedOn;";

                await context.ExecuteAsync(sql, author);

                return author;
            }
        }
        #endregion

        #region Delete Befehle
        public async Task Remove(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                await context.ExecuteAsync("DELETE FROM Author WHERE Id = @id", new { id });
            }
        }
        #endregion

    }
}
