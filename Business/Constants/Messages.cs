﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductCountOfCategoryError="Bir Kategoride En Fazla 10 Ürün Bulunabilir";
        public static string ProductNameAlreadyExist="Bu İsimde Zaten Başka Bir Ürün Var";
        public static string CategoryLimitExceded="Kategori Limiti Aşıldıgı İçin Yeni Ürün Eklenemiyor";
    }
}
