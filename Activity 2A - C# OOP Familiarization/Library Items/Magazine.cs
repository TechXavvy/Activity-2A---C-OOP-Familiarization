using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity_2A___C__OOP_Familiarization.Library;

namespace Activity_2A___C__OOP_Familiarization.Library_Items
{
    public class Magazine : LibDetails
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, string author, string isbn, int issuenumber) : base(title, author, isbn)
        {
            IssueNumber = issuenumber;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"=================================================\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nIssue number: {IssueNumber}\nAvailable?: {!isBorrowed}\n=================================================");
        }
    }
}
