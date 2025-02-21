using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //объект с именем edition,конструктор без параметров
            Edition edition = new Edition();
            Console.WriteLine(edition.ToString());
            //объект с именем editon,конструктор c параметрами
            Edition edition2 = new Edition("Лев", "Николаевич", 1908);
            Console.WriteLine(edition2.ToString());
            //конструктор с parse
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите год издания");
            int year = int.Parse(Console.ReadLine());
            Edition edition3 = new Edition(name, surname, year);
            Console.WriteLine($"{edition3.ToString()}\n{edition3.ChangePublicationYearRange(year)}\n{edition3.FallIntoYear(year)}");
        }
    }
}
