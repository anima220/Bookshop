using Nordblick.Bookshop.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects.Interfaces
{
    public interface IGenreRepository
    {
        Task<Genre> Find(int id);
        Task <IEnumerable<Genre>> GetAll();
        Task<Genre> Add(Genre genre);
        Task<Genre> Update(Genre genre);
        Task Remove(int id);
    }
}
