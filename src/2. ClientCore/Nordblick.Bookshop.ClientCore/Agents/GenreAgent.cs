using Nordblick.Bookshop.BusinessObjects;
using Nordblick.BookShop.ClientCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.ClientCore.Agents
{
    public class GenreAgent : BaseRequest
    {       
        public GenreAgent(string urlPrefix) : base(urlPrefix)
        {

        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            var url = $"{UrlPrefix}api/v1/Genre";

            return await GetIEnumerableAsync<Genre>(url);
        }
        public async Task<Genre> Find(int id)
        {
            var url = $"{UrlPrefix}api/v1/Genre/{id}";

            return await GetAsync<Genre>(url);
        }

        public async Task<Genre> Add(Genre genre)
        {
            var url = $"{UrlPrefix}api/v1/Genre/";

            return await PostAsyncResponse<Genre>(url, genre);
        }

        public async Task<Genre> Update(Genre genre)
        {
            var url = $"{UrlPrefix}api/v1/Genre/{genre.Id}";

            return await PutAsyncResponse<Genre>(url, genre);
        }

        public async Task Remove(int id)
        {
            var url = $"{UrlPrefix}api/v1/Genre/{id}";

            await DeleteAsync(url);
        }
    }
}
