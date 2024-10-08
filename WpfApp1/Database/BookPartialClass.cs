using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfApp1.Classes;
using WpfApp1.Pages;
using WpfApp1.Database;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WpfApp1.Database
{
    public partial class Book
    {
        public SolidColorBrush DiscountColor
        {
            get
            {
                var maxDiscount = Classes.DatabaseConnectionClass.DatabaseConnection.MaxDiscount.Where(c => c.MaxDiscountId == MaxDiscountId).FirstOrDefault();
                if (maxDiscount != null)
                {
                    if (maxDiscount.Value >= 15)
                        return Brushes.Chartreuse;
                    else if (maxDiscount.Value == 10)
                        return Brushes.Orange;
                    else if (maxDiscount.Value == 5)
                        return Brushes.Yellow;
                }
                return Brushes.Transparent;
            }
        }
    }
}
