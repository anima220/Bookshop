using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class Book
    {
        public int Id { get; set; }

        public int PublisherId { get; set; }

        [StringLength(500)]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? PublishingYear { get; set; }

        [Display(Name = "Seitenzahl")]
        public int PageCount { get; set; }

        [StringLength(100)]
        [Display(Name = "Auflage")]
        public string Edition { get; set; }

        [Display(Name = "Preis")]
        public double Price { get; set; }

        [Display(Name = "Verfügbarkeit")]
        public int AvailabilityState { get; set; }

        [Display(Name = "Covertyp")]
        public int CoverType { get; set; }

        public bool IsEBook { get; set; }

        [Display(Name = "Status")]
        public int State { get; set; }

        [Display(Name = "Isbn")]
        public string Isbn { get; set; }

        [Display(Name = "Erstellt am")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Erstellt von")]
        public int CreatedBy { get; set; }

        [Display(Name = "Zuletzt verändert am")]
        public DateTime? ChangedOn { get; set; }

        [Display(Name = "Verändert von")]
        public int ChangedBy { get; set; }

        public static Book GetNewBook()
        {
            return new Book
            {
                Title = "Marry Schotter",
                PublishingYear = DateTime.Now,
                PageCount = 350,
                Edition = "1. Edition",
                Price = 25,
                AvailabilityState = 1,
                CoverType = 1,
                IsEBook = false,
                State = 1,
                Isbn = "9781524721251",
                CreatedOn = DateTime.Now,
                CreatedBy = 1,
                ChangedOn = DateTime.Now,
                ChangedBy = 1
            };
        }

        public override string ToString()
        {
            return $"Id: {Id} Title: {Title} Preis: {Price} Seitenzahl: {PageCount}";
        }
    }
}
