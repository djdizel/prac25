using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prac25
{
    internal class Edition
    {
        /// <summary>
        /// Поля
        /// </summary>
        string name;
        string surname;
        int year;
        /// <summary>
        /// свойство с методами доступа get и set
        /// </summary>
        public string Name {
            get { return (name != "") ? name : "неизвестно"; } 
            set => name = value; }
        public string Surname
        {
            get { return (surname != "") ? surname : "неизвестно"; }
            set => surname = value; }
        public int Year {
            get { return (year != 0) ? year : 0; }
            set
            {if (value < 1990)
                {
                    year = 1990;
                }
                else if (value > 2024)
                {
                    year = 2024;
                }
                else
                {
                    year = value;
                }
            }
        }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Edition() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="year"></param>
        public Edition(string name,string surname, int year) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Year = year;
        }
        /// <summary>
        /// изменить год издания, увеличив или 
        /// уменьшив его на указанное число лет
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public int ChangePublicationYearRange(int year)
        {
            if (year>1990 && year<2024)
            {
                return year;
            }
            else 
            {
                year = 2000;
            }
            return year;
        }
        /// <summary>
        /// определить, попадает ли год издания в заданный интервал
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public string FallIntoYear(int year)
        {
            if (year > 1990 && year < 2024)
            {
                return "Попадает в интервал";
            }
            else
            {
                return "Не попадает в интервал";
            }
        }
        /// <summary>
        /// метод для вывода значений об объекте.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name = {Name}, Surname = {Surname}, Year = {Year}";
        }
    }
}
