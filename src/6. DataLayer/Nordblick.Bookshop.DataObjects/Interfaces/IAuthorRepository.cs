using Nordblick.Bookshop.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects.Interfaces
{
    public interface IAuthorRepository
    {
        Task<Author> Find(int id);
        Task<IEnumerable<Author>> GetAll();
        Task<Author> Add(Author author);
        Task<Author> Update(Author author);
        Task Remove(int id);
    }
}
