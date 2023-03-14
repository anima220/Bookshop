using Nordblick.Bookshop.DataObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects
{
    public interface IUnitOfWork
    {
        IBookRepository Book { get; }
        IAuthorRepository Author { get; }
        IPublisherRepository Publisher { get; }
        IGenreRepository Genre { get; }
    }
}
