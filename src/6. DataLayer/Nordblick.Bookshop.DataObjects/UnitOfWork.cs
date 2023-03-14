using Microsoft.Extensions.Options;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.DataObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.DataObjects
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly string _dapperConnectionString;

        public UnitOfWork(IOptions<ConnectionStringList> connectionStrings)
        {
            _dapperConnectionString = connectionStrings.Value.DapperContextString;
        }

        private IBookRepository _bookRepository;
        public IBookRepository Book => _bookRepository ?? (_bookRepository = new BookRepository(_dapperConnectionString));

        private IAuthorRepository _authorRepository;
        public IAuthorRepository Author => _authorRepository ?? (_authorRepository = new AuthorRepository(_dapperConnectionString));

        private IPublisherRepository _publisherRepository;
        public IPublisherRepository Publisher => _publisherRepository ?? (_publisherRepository = new PublisherRepository(_dapperConnectionString));

        private IGenreRepository _genreRepository;
        public IGenreRepository Genre => _genreRepository ?? (_genreRepository = new GenreRepository(_dapperConnectionString));
    }
}


