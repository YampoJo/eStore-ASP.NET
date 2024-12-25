using Microsoft.AspNetCore.Identity.UI.Services;

namespace WebStore.Services.Email
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {

            await Task.CompletedTask;
        }
    }
}
