using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFlagArgument.Original
{
    public interface IEmailSender
    {
        void SendEmail(string title, string content);
    }
}
