using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class Genre
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public bool IsEditable { get; set; }

        [Display(Name = "Erstellt am")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Erstellt von")]
        public int CreatedBy { get; set; }

        [Display(Name = "Zuletzt verändert am")]
        public DateTime? ChangedOn { get; set; }

        [Display(Name = "Verändert von")]
        public int ChangedBy { get; set; }

        public static Genre GetNewGenre()
        {
            return new Genre
            {
                Description = "Super-Horror",
                IsEditable = false,
                CreatedOn = DateTime.Now,
                CreatedBy = 1,
                ChangedOn = DateTime.Now,
                ChangedBy = 1
            };
        }

        public override string ToString()
        {
            return $"Id: {Id} Genre: {Description}";
        }
    }
}
