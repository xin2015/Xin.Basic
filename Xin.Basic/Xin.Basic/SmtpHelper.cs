using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Xin.Basic
{
    public class SmtpHelper
    {
        private static string host;
        private static string from;
        private static string password;

        static SmtpHelper()
        {
            host = System.Configuration.ConfigurationManager.AppSettings["MailHost"];
            from = System.Configuration.ConfigurationManager.AppSettings["MailFrom"];
            password = System.Configuration.ConfigurationManager.AppSettings["MailPassword"];
        }

        public static void Send(string subject, string body, params string[] to)
        {
            using (SmtpClient sc = new SmtpClient())
            {
                sc.Host = host;
                sc.Credentials = new NetworkCredential(from, password);
                sc.EnableSsl = true;

                MailMessage mm = new MailMessage();
                mm.From = new MailAddress(from);
                foreach (string toAddress in to)
                {
                    mm.To.Add(toAddress);
                }
                mm.Subject = subject;
                mm.Body = body;

                sc.Send(mm);
                mm.Dispose();
            }
        }
    }
}
