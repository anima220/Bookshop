using Nordblick.Bookshop.BusinessObjects;
using Nordblick.BookShop.ClientCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.ClientCore.Agents
{
    public class PublisherAgent : BaseRequest
    {
        public PublisherAgent(string urlPrefix) : base(urlPrefix)
        {

        }
        public async Task<IEnumerable<Publisher>> GetAll()
        {
            var url = $"{UrlPrefix}api/v1/Publisher";

            return await GetIEnumerableAsync<Publisher>(url);
        }
        public async Task<Publisher> Find(int id)
        {
            var url = $"{UrlPrefix}api/v1/Publisher/{id}";

            return await GetAsync<Publisher>(url);
        }

        public async Task<Publisher> Add(Publisher publisher)
        {
            var url = $"{UrlPrefix}api/v1/Publisher/";

            return await PostAsyncResponse<Publisher>(url, publisher);
        }

        public async Task<Publisher> Update(Publisher publisher)
        {
            var url = $"{UrlPrefix}api/v1/Publisher/{publisher.Id}";

            return await PutAsyncResponse<Publisher>(url, publisher);
        }

        public async Task Remove(int id)
        {
            var url = $"{UrlPrefix}api/v1/Publisher/{id}";

            await DeleteAsync(url);
        }
    }
}
