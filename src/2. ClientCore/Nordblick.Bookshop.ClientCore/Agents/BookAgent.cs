using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.BookShop.ClientCore;

namespace Nordblick.Bookshop.ClientCore.Agents
{
    public class BookAgent : BaseRequest
    {
        public BookAgent(string urlPrefix) : base(urlPrefix)
        {
            
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            var url = $"{UrlPrefix}api/v1/Book";

            return await GetIEnumerableAsync<Book>(url);
        }
        public async Task<Book> Find(int id)
        {
            var url = $"{UrlPrefix}api/v1/Book/{id}";

            return await GetAsync<Book>(url);
        }
        public async Task<IEnumerable<Book>> GetBooksByPublisherId(int id)
        {
            var url = $"{UrlPrefix}api/v1/Publisher/{id}/Book";
               
            return await GetIEnumerableAsync<Book>(url);
        }

        public async Task<IEnumerable<Book>> GetBooksByAuthorId(int id)
        {
            var url = $"{UrlPrefix}api/v1/Author/{id}/Book";

            return await GetIEnumerableAsync<Book>(url);
        }
        public async Task<Book> Add(Book book)
        {
            var url = $"{UrlPrefix}api/v1/Book/";

            return await PostAsyncResponse<Book>(url, book);
        }

        //help
        //public async void Task<Book> AddGenreToBook(int bookId, int genreId)
        //{
        //    var url = $"{UrlPrefix}api/v1/Book/{bookId}/genre/{genreId}";

        //     await PostAsync<Book>(url, null);
        //}

        //public async void Task<Book> AddAuthorToBook(int bookId, int authorId)
        //{
        //    var url = $"{UrlPrefix}api/v1/Book/{bookId}/Author/{authorId}";

        //    await PostAsync<Book>(url, null);
        //}

        public async Task<Book> Update(Book book)
        {
            var url = $"{UrlPrefix}api/v1/Books/{book.Id}";

            return await PutAsyncResponse<Book>(url, book);
        }

        public async Task Remove(int id)
        {
            var url = $"{UrlPrefix}api/v1/Book/{id}";

            await DeleteAsync(url);
        }


    }
}
