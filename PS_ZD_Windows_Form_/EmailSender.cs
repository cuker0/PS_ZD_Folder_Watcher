using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PS_ZD_Windows_Form_
{
    public class EmailSender
    {
       
        public async Task EmailSendAsync(string watchingDir, string fileName)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            Credentials name = new Credentials();

            client.Credentials = new NetworkCredential()
            {
                UserName = "balluffkurscsharp@gmail.com",
                Password = "0okmNJI("
            };

            client.EnableSsl = true;

            MailMessage message = new MailMessage();
            message.From = new MailAddress("balluffkurscsharp@gmail.comm", "Balluff Kurs Programowania");
            message.To.Add(new MailAddress("marcin.cukrowski@gmail.com", "Marcin Cukrowski"));
            message.Subject = "Kurs C# - informacja o zmianach w folderze";
            message.Body = $"Uwaga,\r\n nastąpiła zmiana w folderze {watchingDir} na pliku {fileName} .\r\n ";

            await client.SendMailAsync(message);  //wyslanie maila asynchronicznie 

           
        }


    }
}
