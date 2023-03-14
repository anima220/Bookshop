using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class Author
    {
        public int Id { get; set; }

        public int PublisherId { get; set; }

        [StringLength(200)]
        [Display(Name = "Vorname")]
        public string FirstName { get; set; }


        [StringLength(200)]
        [Display(Name = "Nachname")]
        public string LastName { get; set; }

        [Display(Name = "Geburtsdatum")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd.MM.yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public bool IsAlive { get; set; }

        [Display(Name = "Buchanzahl")]
        public int BookCount { get; set; }

        [Display(Name = "Status")]
        public int State { get; set; }

        [Display(Name = "Erstellt am")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Erstellt von")]
        public int CreatedBy { get; set; }

        [Display(Name = "Zuletzt verändert am")]
        public DateTime? ChangedOn { get; set; }

        [Display(Name = "Verändert von")]
        public int ChangedBy { get; set; }

        public static Author GetNewAuthor()
        {
            return new Author
            {
                FirstName = "Mark",
                LastName = "Nachname",
                State = 1,
                Birthdate = DateTime.Now,
                IsAlive = true,
                BookCount = 12,
                CreatedOn = DateTime.Now,
                CreatedBy = 1,
                ChangedOn = DateTime.Now,
                ChangedBy = 1
            };
        }

        public string ToStringList()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var propList = this.GetType().GetProperties(); //Sammelt alle Properties eines Objects und speichert diese.

            foreach (var p in propList) //durchgeht jede einzelne Eigenschaft
            {
                stringBuilder.Append(p.Name.ToString()); //Fügt Eigenschaftennamen zum String hinzu
                stringBuilder.Append(": ");
                if (p.GetValue(this) == null) //fragt ab, ob der Wert der jeweiligen Eigenschaft Null ist und fügt "Null" ein wenn true (sonst => Error)
                {
                    stringBuilder.AppendLine("Null");
                }
                else //wenn Wert vorhanden wird er dem String angefügt
                {

                    stringBuilder.AppendLine(p.GetValue(this).ToString());
                }

            }
            stringBuilder.AppendLine("");

            return stringBuilder.ToString();

        }
    }
}
