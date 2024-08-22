
using System.Net.Http.Headers;

/**
 * This example does not use some C# features to demonstrate
 * how it works in other languages.
 * 
 * Wrap the record in a class and gradually move things from the record to the class
 * Check OneNote note on the steps to encapsulate the record.
 **/
namespace EncapsulateRecord.Refactored
{
    public class Profile
    {
        private string _name;
        private string _email;

        public Profile(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public string GetName() { return _name; }
        public string GetEmail() { return _email; }
    }
    public class IssueReporter
    {
        private Profile ContactPersonProfile;

        public IssueReporter()
        {
            ContactPersonProfile = new("Jerry", "jerry@somecorp.com");
        }

        private Profile GetContactPersonProfile()
        {
            return ContactPersonProfile;
        }

        public void ReportIssue(string issue)
        {
            string title = $"Dear {GetContactPersonProfile().GetName()}, there has been an issue";
            string message = $"Details about the issue: {issue}";
            SendEmail(GetContactPersonProfile().GetEmail(), title, message);
        }

        private void SendEmail(string email, string title, string message)
        {
            //send the email to the security personel
        }
    }
}
