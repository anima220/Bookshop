using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nordblick.Bookshop.BusinessObjects;
using Nordblick.Bookshop.ClientCore;

namespace Nordblick.Bookshop.WebShop.Pages.Books
{
    public class BooksDetailsModel : PageModel
    {

        private readonly IAgentOfWork _agentOfWork;

        public BooksDetailsModel(IAgentOfWork agentOfWork)
        {
            _agentOfWork = agentOfWork;
        }

        public Book currentBook;

        public async Task OnGet(int id)
        {
            var book = await _agentOfWork.Book.Find(id);
            
            currentBook = book;
        }
    
    }
}