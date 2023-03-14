using Nordblick.Bookshop.BusinessObjects;
using Nordblick.BookShop.ClientCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.ClientCore.Agents
{
    public class AuthorAgent : BaseRequest
    {
        public AuthorAgent(string urlPrefix) : base(urlPrefix)
        {

        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            var url = $"{UrlPrefix}api/v1/Author";

            return await GetIEnumerableAsync<Author>(url);
        }
        public async Task<Author> Find(int id)
        {
            var url = $"{UrlPrefix}api/v1/Author/{id}";

            return await GetAsync<Author>(url);
        }

        public async Task<Author> Add(Author author)
        {
            var url = $"{UrlPrefix}api/v1/Author/";

            return await PostAsyncResponse<Author>(url, author);
        }

        public async Task<Author> Update(Author author)
        {
            var url = $"{UrlPrefix}api/v1/Author/{author.Id}";

            return await PutAsyncResponse<Author>(url, author);
        }

        public async Task Remove(int id)
        {
            var url = $"{UrlPrefix}api/v1/Author/{id}";

            await DeleteAsync(url);
        }
    }
}
