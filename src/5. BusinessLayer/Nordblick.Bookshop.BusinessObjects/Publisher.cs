using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class Publisher
    {
        public int Id { get; set; }

        public int PublisherId { get; set; }

        [Required(ErrorMessage = "Ein Gründungsdatum ist notwendig")]
        [Display(Name = "Gründungsdatum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? FoundationDate { get; set; }

        [Required(ErrorMessage = "Ein Name ist notwendig")]
        [StringLength(500)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Eine E-Mail ist notwendig")]
        [StringLength(500)]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        public bool IsActive { get; set; }

        [Display(Name = "Erstellt am")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Erstellt von")]
        public int CreatedBy { get; set; }

        [Display(Name = "Zuletzt verändert am")]
        public DateTime? ChangedOn { get; set; }

        [Display(Name = "Verändert von")]
        public int ChangedBy { get; set; }

        public static Publisher GetNewPublisher()
        {
            return new Publisher
            {
                Name = "Sandverkauf GmbH",
                Email = "Sand@Verkauf.de",
                FoundationDate = DateTime.Now,
                IsActive = true,
                CreatedOn = DateTime.Now,
                CreatedBy = 1,
                ChangedOn = DateTime.Now,
                ChangedBy = 1
            };
        }

        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} E-Mail: {Email}";
        }
    }
}
