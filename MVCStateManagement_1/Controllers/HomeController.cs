using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStateManagement_1.Controllers
{
    public class HomeController : Controller
    {
        /*
         
         
        State Management(Durum Yönetimleri) => İkiye ayrılırlar (Server Side, Client Side)


        Server Side'daki durum Yönetimleri => Session ve Application State'lerdir

        1) Session her kişi icin ayrı bir oturum alanında saklanan verileri tutar...
        2) Application State herkesin görecegi bir State'tir...




        Client Side'daki durum yönetimleri => Cookie ve Cache

        1) Cookie, remember me vs. durumlarında ilgili alanlara kullanıcı isminiz ve şifrenizi tekrar yazmaktansa browser'iniz cerezlerinde bunları kaydetmenizi saglarak oradan bu bilgileri getirir...Browser bazlı calısır...

        2) Cache => Performans yönerimi icin (class list vs) server'in degil Client'in sistemini kullanarak karsınıza veri getirmeyi daha kolay bir hale sokan yapılardır...
         
         
         
         
         
         
         
         
         
         */
        public ActionResult SessionState()
        {
            #region SessionState
            //SessionState => Sunucu (server) tarafında siteye baglanan her bir kullanıcı icin olusturulan ayrı bir hafıza bölgesidir...Bu kullanıcı ile ilgili bazı bilgileri saklamak istiyorsak(giriş yapan kullanıcı nesnesi, sepet) bunu Session dedigimiz alanlarda yaparız...Session kullanıbı bazlı olusur. Eger siz girdiginizde Session yaratılırsa o anki kullanıcıya(size) özel bir hafıza alanı yaratılır...

            //Session key,value mantıgında calısır...Object veri tutar
            #endregion
            return View();
        }


        [HttpPost]
        public ActionResult SessionState(string veri)
        {
            Session["veri"] = veri;
            return RedirectToAction("SessionState");   
        }



        public ActionResult SessionTest()
        {
            return View();
        }
    }
}