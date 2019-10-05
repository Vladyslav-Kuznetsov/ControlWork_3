using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_3
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Book> books = new List<Book>()
            {
                new Book("LINQ tutorial",1996),
                new Book("The Witcher", 2000),
                new Book("LINQ 2.0", 2016)
            };

            Console.WriteLine(string.Join(", ", books.Where(book => book.Name.Contains("LINQ") && DateTime.IsLeapYear(book.Year)).Select(book => book.Name))); //1

            List<string> russianWords = new List<string>()
            {
                "Слова",
                "для",
                "контрольной",
                "работы"
            };

            Console.WriteLine(russianWords.SelectMany(str => str).Distinct().Count()); //2

            int[] array = new int[] { 19, 23, 47, 22, 94, 33, 63, 79, 57, 62, 65, 68 };


            Console.WriteLine(string.Join(",", array.OrderBy(num => num / 10).ThenByDescending(num => num % 10))); //3

            Book[] arrayBook = new Book[]
            {
                new Book("Author1", 1975),
                new Book("Author2", 1999),
                new Book("Author3", 2000),
                new Book("Author1", 1998)
            };

            Console.WriteLine(string.Join(", ", arrayBook.GroupBy(book => book.Name).Select(b => $"{b.Key} {b.Count()}"))); //4
            Console.ReadLine();
        }
    }
}
