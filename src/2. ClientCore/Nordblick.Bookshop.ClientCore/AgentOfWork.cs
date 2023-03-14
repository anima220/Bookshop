using Microsoft.Extensions.Options;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.ClientCore.Agents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.ClientCore 
{
    public class AgentOfWork : IAgentOfWork
    {
        private readonly string _apiConnectionString;

        public AgentOfWork(IOptions<ApiStringList> apiStrings)
        {
            _apiConnectionString = apiStrings.Value.ApiContextString;
        }

        private BookAgent _bookAgent;

        private AuthorAgent _authorAgent;

        private GenreAgent _genreAgent;

        private PublisherAgent _publisherAgent;

        public BookAgent Book => _bookAgent ?? (_bookAgent = new BookAgent(_apiConnectionString));

        public AuthorAgent Author => _authorAgent ?? (_authorAgent = new AuthorAgent(_apiConnectionString));

        public GenreAgent Genre => _genreAgent ?? (_genreAgent = new GenreAgent(_apiConnectionString));

        public PublisherAgent Publisher => _publisherAgent ?? (_publisherAgent = new PublisherAgent(_apiConnectionString));




    }
}
