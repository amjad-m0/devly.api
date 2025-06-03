using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System.Net;
using System.Net.Mail;

namespace Devly.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        public class ContactForm
        {
            public string Name { get; set; } = "";
            public string Email { get; set; } = "";
            public string Message { get; set; } = "";
        }
        [HttpPost]
        public IActionResult Post(ContactForm form)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Devly Site", "noreply@yourdomain.com"));
            message.To.Add(new MailboxAddress("Amjad", "amjad.safouh@gmail.com"));
            message.ReplyTo.Add(new MailboxAddress(form.Name, form.Email));

            message.Subject = $"📩 New Contact Message from {form.Name}";
            message.Body = new TextPart("plain")
            {
                Text = $"Name: {form.Name}\nEmail: {form.Email}\n\nMessage:\n{form.Message}"
            };

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.yourdomain.com", 587, MailKit.Security.SecureSocketOptions.StartTls); // Use TLS
            smtp.Authenticate("noreply@yourdomain.com", "your-password");
            smtp.Send(message);
            smtp.Disconnect(true);

            return Ok(new { success = true });
        }
    }
}

