

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1;
            b1 = new Book();
            b1.Title = "Test";
            b1.Pages = 10;
            Console.WriteLine(b1.Title);
            Console.WriteLine(b1.Pages);
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Equals(b1));
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b1.GetType());

            #region q3
            //compile time error
            #endregion

            #region q4

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Second code");

            int firstnum = 10;
            int secondnum = 0;
            try
            {
                int result = firstnum / secondnum;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot devide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region q5
            int pages = 300;
            double dpages = pages;
            Console.WriteLine(dpages);
            #endregion

            #region q6
            double price = 49.99;
            int newPrice = (int)price;
            Console.WriteLine(newPrice);
            #endregion

            #region q7
            string pagesText = "464";
            int trans = Convert.ToInt32(pagesText);
            Console.WriteLine(trans);
            #endregion

            #region q8
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            string badText = "abc";
            bool bad = int.TryParse(badText, out int value);
            if (bad)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region q9
            int pagesn = 464;
            string New = pagesn.ToString();
            Console.WriteLine(New.GetType());
            #endregion

            #region q10
            int copies = 100;
            object y = copies;
            int m = (int)y;
            Console.WriteLine(y);
            Console.WriteLine(m);
            #endregion

            #region q11
            int? Year = null;
            Console.WriteLine(Year.HasValue);
            Year = 2023;
            Console.WriteLine(Year.Value);
            #endregion

            #region q12
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            #endregion

            #region q13
            Book? book = null;
            Console.WriteLine(book?.Title);
            #endregion

            #region q14
            string? title = null;
            // Using ??
            Console.WriteLine(title ?? "Untitled");
            // Using ??=
            title ??= "Untitled";
            Console.WriteLine(title);
            #endregion

            #region q15
            string? name = "Ahmed";
            string Name = name!;
            Console.WriteLine(Name);
            #endregion







        }
    }
}
