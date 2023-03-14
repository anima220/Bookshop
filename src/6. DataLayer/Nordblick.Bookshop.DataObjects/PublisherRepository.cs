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
    public class PublisherRepository : IPublisherRepository
    {
        private readonly string _dapperConnectionString;

        public PublisherRepository(string connectionString)
        {
            _dapperConnectionString = connectionString;
        }

        #region Read Befehle 
        public async Task<IEnumerable<Publisher>> GetAll()
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryAsync<Publisher>("SELECT * FROM Publisher;");
                
                return result;
            }
        }
        public async Task<Publisher> Find(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryFirstOrDefaultAsync<Publisher>("SELECT * FROM Publisher WHERE Id = @id;", new { id });
                return result;
            }
        }

        #endregion

        #region Create Befehle
        public async Task<Publisher> Add(Publisher publisher)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                publisher.CreatedOn = DateTime.Now;
                publisher.ChangedOn = DateTime.Now;

                var sql = ("INSERT INTO Publisher (BookId, FoundationDate, Name, EMail, IsActive, CreatedOn,CreatedBy, ChangedBy, ChangedOn) " +
                                                   "VALUES" +
                                                   "(@BookId, @FoundationDate, @Name, @EMail, @IsActive, @CreatedOn, @CreatedBy, @ChangedBy, @ChangedOn);" +
                                                   "SELECT CAST (SCOPE_IDENTITY() as int)");
                var id = await context.QuerySingleAsync<int>(sql, publisher);
                publisher.Id = id;

                return publisher;
            }
        }
        #endregion

        #region Update Befehle
        public async Task<Publisher> Update(Publisher publisher)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                publisher.ChangedOn = DateTime.Now;
                
                var sql = "UPDATE Publisher SET BookId = @BookId, FoundationDate = @FoundationDate, Name = @Name, IsActive = @IsActive" +
                                               "CreatedOn = @CreatedOn, CreatedBy = @CreatedBy, ChangedBy = @ChangedBy, ChangedOn = @ChangedOn;";

               await context.ExecuteAsync(sql, publisher);

                return publisher;
            }
        }
        #endregion
        
        #region Delete Befehle
        public async Task Remove(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
               await context.ExecuteAsync("DELETE FROM Publisher WHERE Id = @id", new { id });
            }
        }
        #endregion

    }
}
