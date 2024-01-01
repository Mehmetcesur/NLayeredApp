using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Messages
{
    public class BusinessMessages
    {
        public static string CategoryLimit = "Kategori sayısı max 10 olablir.";
        public static string ProductLimit = "Bir kategoride Ürün sayısı max 20 olablir.";
        public static string ContactNameLimit = "Aynı contactName'den 1'den fazla olamaz!";
        public static string CityLimit = "Bir şehirde maksimum 10 müşteri kabul ediyoruz!";
    }
}
