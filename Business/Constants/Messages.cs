using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameIncalid = "Ürün ismi gecersiz";
        internal static string MaintenanceTime = "Sistem Bakımda";
        internal static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride 10 fazla ürün olamaz ";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiiniz Yok";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string AccessTokenCreated;

        public static string UserAlreadyExists { get; internal set; }
    }
}
