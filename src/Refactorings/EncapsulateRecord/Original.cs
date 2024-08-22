/**
 * This example does not use some C# features to demonstrate
 * how it works in other languages.
 **/
namespace EncapsulateRecord.Original
{
    public class ProfileRecord
    {
        public string Name;
        public string Email;
    }
    public class IssueReporter
    {
        private ProfileRecord ContactPerson = new ProfileRecord
        {
            Name = "Jerry",
            Email = "jerry@somecorp.com"
        };

        public void ReportIssue(string issue)
        {
            string title = $"Dear {ContactPerson.Name}, there has been an issue";
            string message = $"Details about the issue: {issue}";
            SendEmail(ContactPerson.Email, title, message);
        }

        private void SendEmail(string email, string title, string message)
        {
            //send the email to the security personel
        }
    }
}
