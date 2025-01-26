using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity_2A___C__OOP_Familiarization.Library;

namespace Activity_2A___C__OOP_Familiarization.Library_Items
{
    public class Book : LibDetails
    {
        public int PageCount {  get; set; }
        
        public Book(string title, string author, string isbn, int pagecount) : base(title, author, isbn)
        {
            PageCount = pagecount;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"=================================================\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}\nNo. of pages: {PageCount}\nAvailable?: {!isBorrowed}\n=================================================");
        }
    }
}
