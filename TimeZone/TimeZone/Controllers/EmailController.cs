using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System;

namespace TimeZone.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string to, string subject, string body)
        {
            // Configure the SMTP client settings
            SmtpClient smtpClient = new SmtpClient("smtp.example.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("your_email@example.com", "your_password"),
                EnableSsl = true,
            };

            // Create the email message
            MailMessage message = new MailMessage
            {
                From = new MailAddress("your_email@example.com"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true, // You can set this to true if your email content is HTML
            };

            // Add recipients
            message.To.Add(to);

            try
            {
                // Send the email
                smtpClient.Send(message);
                ViewBag.Message = "Email sent successfully!";
            }
            catch (Exception ex)
            {
                ViewBag.Message = $"Error: {ex.Message}";
            }

            return View();
        }
    }
}
