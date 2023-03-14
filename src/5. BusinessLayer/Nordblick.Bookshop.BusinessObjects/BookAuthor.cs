using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class BookAuthor
    {
        public int AuthorId { get; set; }
        public int BookId { get; set; }
        public bool IsMainAuthor { get; set; }
    }
}
