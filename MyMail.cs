using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ECommercialSite
{
	public class MyMail
	{
		public string ToMail { get; private set; }
		public string Subject { get; private set; }
		public string Body { get; set; }
		public MyMail(string _tomail, string _subject, string _body)
		{
			this.ToMail = _tomail;
			this.Subject = _subject;
			this.Body = _body;
		}
		public void SendMail()
		{
			MailMessage mail = new MailMessage()
			{
				From = new MailAddress("burakkucukali6@gmail.com", "Burak Küçükali - Admin")
			};
			mail.To.Add(this.ToMail);
			mail.Subject = this.Subject;
			mail.Body = this.Body;

			SmtpClient client = new SmtpClient()
			{
				Port=587,
				Host="smtp.gmail.com",
				EnableSsl=true
			};
			client.Credentials = new System.Net.NetworkCredential("burakkucukali6@gmail.com", "b286286K");

			client.Send(mail);
		}
	}
}