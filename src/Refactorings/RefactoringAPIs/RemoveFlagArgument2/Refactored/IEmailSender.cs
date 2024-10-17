using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveFlagArgument2.Refactored
{
    public interface IEmailSender
    {
        void SendEmail(string title, string content);
    }
}
