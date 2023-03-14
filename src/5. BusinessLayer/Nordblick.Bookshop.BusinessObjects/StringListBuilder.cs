using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nordblick.Bookshop.BusinessObjects
{
    public class StringListBuilder<T>
    {
        private List<T> allItems;

        public StringListBuilder(List<T> itemList)
        {
            allItems = itemList;
        }

        public string RunFatClient()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (T item in allItems)
            {
                stringBuilder.AppendLine(item.ToString()); //überschriebene ToString Methode   
            }

            return stringBuilder.ToString();
        }       

        public string RunWebClient()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (T item in allItems) 
            {
                stringBuilder.Append("<li>");
                stringBuilder.Append(item.ToString()); //überschriebene ToString Methode   
                stringBuilder.Append("</li>");
                stringBuilder.Append(Environment.NewLine);
            }

            return stringBuilder.ToString();
        }
    }
}
