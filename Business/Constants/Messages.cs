using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün adı geçersiz.";
        public static string MaintenanceTime = "Site bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError="Her kategoride en fazla 10 ürün bulunabilir.";
        public static string ProductNameAlreadyExist = "Aynı isimde ürün eklenemez.";
        public static string CategoryLimitExceded= "Kategori limiti aşıldı";
    }
}
