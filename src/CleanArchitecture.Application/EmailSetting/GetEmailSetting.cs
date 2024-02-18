using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.EmailSetting
{
    public class GetEmailSetting
    {
        public string SecretKey { get; set; }
        public string From { get; set; }
        public string SmtpServer { get; set; }
        public int Prot {  get; set; }
        public bool EnableSSL { get; set; }

    }
}
