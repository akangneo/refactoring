using System;
using System.IO;
using System.Net.Mail;

namespace ExtractClass
{
    class Person
    {
        const string FilePath = @"c:\log.txt";

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void SetAddress(string city, string address)
        {
            City = city;
            Address = address;
        }

        public bool SendMailToAddress(string address, string subject, string text)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(EmailAddress);
                mail.To.Add(address);
                mail.Subject = subject;
                mail.Body = text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(UserName, Password);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        void Log(string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(FilePath))
            {
                streamWriter.WriteLine(message);
                streamWriter.Close();
            }
        }

        public string Name { get; }
        public int Age { get; }
        public string City { get; private set; }
        public string Address { get; private set; }
        public string UserName { get; }
        public string EmailAddress { get; }
        public string Password { get; }
    }
}