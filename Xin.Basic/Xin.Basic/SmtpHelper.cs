using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Xin.Basic
{
    /// <summary>
    /// 邮件工具类
    /// </summary>
    public class SmtpHelper
    {
        private static string host;
        private static string from;
        private static string password;
        private static bool enableSsl;

        static SmtpHelper()
        {
            host = System.Configuration.ConfigurationManager.AppSettings["MailHost"];
            from = System.Configuration.ConfigurationManager.AppSettings["MailFrom"];
            password = System.Configuration.ConfigurationManager.AppSettings["MailPassword"];
            enableSsl = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["MailEnableSsl"]);
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="subject">主题</param>
        /// <param name="body">正文</param>
        /// <param name="to">收件人</param>
        public static void Send(string subject, string body, string[] to)
        {
            using (SmtpClient sc = new SmtpClient())
            {
                sc.Host = host;
                sc.Credentials = new NetworkCredential(from, password);
                sc.EnableSsl = enableSsl;

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

        public static void Send(string from, string[] to, string subject, string body, string[] cc, params Attachment[] attachment)
        {
            using (SmtpClient sc = new SmtpClient())
            {
                sc.Host = host;
                sc.Credentials = new NetworkCredential(from, password);
                sc.EnableSsl = enableSsl;

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
