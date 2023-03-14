using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.ClientCore;
using Nordblick.Bookshop.ClientCore.Agents;

namespace Nordblick.Bookshop.WebShop.Pages.Books
{
    public class BooksIndexModel : PageModel
    {
        private readonly IAgentOfWork _agentOfWork;

        public BooksIndexModel(IAgentOfWork agentOfWork)
        {
            _agentOfWork = agentOfWork;
        }

        public List<Book> allBooks;

        public Book currentBook;

        public async Task OnGet()
        {
            var all = await _agentOfWork.Book.GetAll();
            allBooks = new List<Book>(all);

            currentBook = allBooks.First();

        }
    }
}