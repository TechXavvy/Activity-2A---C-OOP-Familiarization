using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_2A___C__OOP_Familiarization.Library
{
    public abstract class LibDetails
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool isBorrowed { get; private set; }

        public LibDetails(string title, string author, string isbn) 
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public abstract void DisplayDetails();

        public virtual bool Borrowing()
        {
            if(isBorrowed == true)
            {
                Console.Write("\nProcessing request... ");
                Console.WriteLine($"Unfortunately, {Title} is already borrowed!");
            }
            else
            {
                Console.Write("\nProcessing request... ");
                Console.WriteLine($"Thank you for waiting! {Title} is successfully borrowed!");
                isBorrowed = true;
            }
            return isBorrowed;
        }
    }
}
