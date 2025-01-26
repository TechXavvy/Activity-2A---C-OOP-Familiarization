using Activity_2A___C__OOP_Familiarization.Library;
using Activity_2A___C__OOP_Familiarization.Library_Items;

namespace Activity_2A___C__OOP_Familiarization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LibDetails> libitems = new List<LibDetails>
            {
                new Book("FaceBook", "Mark Zuckerberg", "123456789", 360),                
                new Book("Book To December", "Taylor Shift", "12131989", 22),
                new Book("TteokBookie", "Korean Foodie", "987654321", 777),
                new Magazine("Magasin", "Shota Aizawa", "11080000", 183),
                new Magazine("UnkaVogueable", "Vize Ganduh", "03311976", 100),
                new Magazine("Phineas&Forbes", "Flynn Fetcher", "04012011", 104),
            };

            Console.WriteLine("Welcome to James' Read! The Most Randomantic Library~~~\n");

            Console.WriteLine("Items in Library:");
            foreach (var item in libitems)
            {
                item.DisplayDetails();
            }

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nBorrowing Items:");
            libitems[1].Borrowing();
            libitems[1].Borrowing();
            libitems[5].Borrowing();

            Console.WriteLine("\n----------------------------------------------------------");
            Console.WriteLine("\nUpdated Items in Library:");
            foreach (var item in libitems)
            {
                item.DisplayDetails();
            }
        }
    }
}
