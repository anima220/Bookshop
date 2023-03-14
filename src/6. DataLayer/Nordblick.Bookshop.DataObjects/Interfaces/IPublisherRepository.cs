using Nordblick.Bookshop.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects.Interfaces
{
    public interface IPublisherRepository
    {
        Task<Publisher> Find(int id);
        Task<IEnumerable<Publisher>> GetAll();
        Task<Publisher> Add(Publisher publisher);
        Task<Publisher> Update(Publisher publisher);
        Task Remove(int id);
    }
}
