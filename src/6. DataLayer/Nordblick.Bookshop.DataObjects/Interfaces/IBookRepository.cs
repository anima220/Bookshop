using Nordblick.Bookshop.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects.Interfaces
{
    public interface IBookRepository
    {
        Task<Book> Find(int id);
        Task<IEnumerable<Book>> GetAll();
        Task<IEnumerable<Book>> GetAllByPublisherId(int id);
        Task<IEnumerable<Book>> GetAllByAuthorId(int id);
        Task<Book> Add(Book book);
        Task AddAuthorToBook(BookAuthor bookAuthor);
        Task AddGenreToBook(int bookId, int genreId);
        Task<Book> Update(Book book);
        Task Remove(int id);
    }
}
