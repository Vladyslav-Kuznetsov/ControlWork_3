using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_3
{
    public class Book
    {
        public string Name { get; set; }
        public int Year { get; set; }
        

        public Book(string name, int year )
        {
            Name = name;
            Year = year;
        }
    }
}
