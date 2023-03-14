using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class AuthorPublisher
    {
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
