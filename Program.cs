using System;
class Book
{
    //qusetion1
  
    public string title;
    public int pages;

}
namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //qusetion1

            Book book1 = new Book();
            book1.title = "c#basice";
            book1.pages = 464;
            object obj = book1;

            //qusetion2
            Console.WriteLine(obj);
            Console.WriteLine(book1.ToString());
            Console.WriteLine(book1.Equals(book1));
            Console.WriteLine(book1.GetType());
            Console.WriteLine(book1.GetHashCode());
            //qusetion3
            /*int pages="464";
             * error type(compile-time error)
             * correction(int pages=464;)*/

            //qusetion4
            try
            {
                int zero = 0;
                int result =10/zero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("cannot divide by zero");
            }

            finally
            {
                Console.WriteLine("done");
            }

          











        }
    }
}
