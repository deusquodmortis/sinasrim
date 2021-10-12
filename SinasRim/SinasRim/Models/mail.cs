using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using SinasRim.Controllers;

namespace SinasRim.Models
{
    public class mail
    {
        public string mailfrom { get; set; }
        public string icerik { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        
        public void mailGönderme(string icerik, string kimden,string adsoyad)
        {
            MailMessage mail = new MailMessage(); //yeni bir mail nesnesi Oluşturuldu.
            mail.IsBodyHtml = true; //mail içeriğinde html etiketleri kullanılsın mı?
            mail.To.Add("contact@sinasrim.com"); //Kime mail gönderilecek.
                               //  mail.To.Add("emredirek1905@gmail.com");
                               //mail kimden geliyor, hangi ifade görünsün?

            mail.From = new MailAddress("deusquodmortis@gmail.com", "İletişim Formu", System.Text.Encoding.UTF8);
            mail.Subject = adsoyad;//mailin konusu

            //mailin içeriği.. Bu alan isteğe göre genişletilip daraltılabilir.
            mail.Body = icerik;

            mail.IsBodyHtml = true;
            SmtpClient smp = new SmtpClient();

            //mailin gönderileceği adres ve şifresi
            smp.Credentials = new NetworkCredential("deusquodmortis@gmail.com", "-Test1234-");
            smp.Port = 587;
            smp.Host = "smtp.gmail.com";//gmail üzerinden gönderiliyor.
            smp.EnableSsl = true;
            smp.Send(mail);//mail isimli mail gönderiliyor.

        }
    }
}