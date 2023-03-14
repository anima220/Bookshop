using Nordblick.Bookshop.ClientCore.Agents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.ClientCore
{
    public interface IAgentOfWork
    {
       BookAgent Book { get; }
       AuthorAgent Author { get; }
       GenreAgent Genre { get; }
       PublisherAgent Publisher { get; }
    }
}
