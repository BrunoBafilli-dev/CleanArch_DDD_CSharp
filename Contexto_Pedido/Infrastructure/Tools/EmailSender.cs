using Application.Events.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Tools
{
    public class EmailSender : IEmailSender
    {
        public void SendEmail(string email)
        {
            Console.WriteLine($"{email} enviado com sucesso!");
        }
    }
}
