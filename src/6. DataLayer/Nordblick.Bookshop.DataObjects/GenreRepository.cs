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
    public class GenreRepository : IGenreRepository
    {
        private readonly string _dapperConnectionString;

        public GenreRepository(string connectionString)
        {
            _dapperConnectionString = connectionString;
        }

        #region Read Befehle 
        public async Task <IEnumerable<Genre>> GetAll()
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryAsync<Genre>("SELECT * FROM Genre;");
                
                return result;
            }
        }
        public async Task<Genre> Find(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                var result = await context.QueryFirstOrDefaultAsync<Genre>("SELECT * FROM Genre WHERE Id = @id;", new { id });
                return result;
            }
        }

        #endregion

        #region Create Befehle
        public async Task<Genre> Add(Genre genre)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                genre.CreatedOn = DateTime.Now;
                genre.ChangedOn = DateTime.Now;

                var sql = ("INSERT INTO Genre (Description, IsEditable, CreatedOn,CreatedBy, ChangedBy, ChangedOn) " +
                                               "VALUES" +
                                               "(@Description, @IsEditable, @CreatedOn, @CreatedBy, @ChangedBy, @ChangedOn);" +
                                               "SELECT CAST (SCOPE_IDENTITY() as int)");
                
                var id = await context.QuerySingleAsync<int>(sql, genre);
                genre.Id = id;

                return genre;
            }
        }
        #endregion

        #region Update Befehle
        public async Task<Genre> Update(Genre genre)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                genre.ChangedOn = DateTime.Now;

                var sql = "UPDATE Genre SET Description = @Description, IsEditable = @IsEditable," +
                          "CreatedOn = @CreatedOn, CreatedBy = @CreatedBy, ChangedBy = @ChangedBy, ChangedOn = @ChangedOn;";

               await context.ExecuteAsync(sql, genre);

                return genre;
            }
        }
        #endregion

        #region Delete Befehle
        public async Task Remove(int id)
        {
            using (IDbConnection context = new SqlConnection(_dapperConnectionString))
            {
                await context.ExecuteAsync("DELETE FROM Genre WHERE Id = @id", new { id });
            }
        }
        #endregion

    }
}
