namespace assignment_5
{
    internal class Program
    {
        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
        static void AddBonusPages(int pages)
        {
            pages += 50;
        }
        static void ApplyDiscount(double[] prices2)
        {
            prices2[0] -= 5;
        }
        static void AddBonusPagesByRef(ref int pages2)
        {
            pages2 += 50;
        }
        static void ReplaceArray(ref double[] prices3)
        {
            prices3 = new double[] { 10.0, 12.5, 15.0 };
        }
        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }
        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }
        static void PrintAllTitles(params string[] titles)
        {
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }
        static void Main( string[] args)
        {

            //السؤال الاول
            Console.WriteLine("------Question 1---");

            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);

            //السؤال التاني
            Console.WriteLine("------Question 2---");

            int[,] shelfCopies =
            {
                   { 3, 5 },
                   { 1, 4 }
            };
            Console.WriteLine(shelfCopies[1, 0]);

            //السؤال التالت
            Console.WriteLine("------Question 3---");

            PrintWelcomeMessage();

            //السؤال الرابع
            Console.WriteLine("------Question 4---");

            PrintBookTitle("Clean Code");

            //السؤال الخامس
            Console.WriteLine("------Question 5---");

            int pages = 400;
            AddBonusPages(pages);
            Console.WriteLine(pages);

            //السؤال السادس
            Console.WriteLine("------Question 6---");

            double[] prices2 = { 25.5, 40.0 };
            ApplyDiscount(prices2);
            Console.WriteLine(prices2[0]);

            //السؤال السابع
            Console.WriteLine("------Question 7---");

            int pages2 = 400;
            AddBonusPagesByRef(ref pages2);
            Console.WriteLine(pages2);

            //السؤال التامن
            Console.WriteLine("------Question 8---");

            double[] prices3 = { 25.5, 40.0, 33.75 };
            ReplaceArray(ref prices3);
            Console.WriteLine(prices3.Length);

            //السؤال التاسع
            Console.WriteLine("------Question 9---");

            if (TryGetPrice("Clean Code", out double foundPrice))
            {
                Console.WriteLine(foundPrice);
            }

            //السؤال العاشر
            Console.WriteLine("------Question 10---");

            PrintBookInfo("Clean Code");
            PrintBookInfo("The Pragmatic Programmer", 352);

            //السؤال ال11
            Console.WriteLine("------Question 11---");

            PrintBookInfo(pages: 450, title: "Design Patterns");

            //السؤال ال12
            Console.WriteLine("------Question 12---");

            PrintAllTitles("Clean Code", "Refactoring", "Domain-Driven Design");

        }
    }
}
