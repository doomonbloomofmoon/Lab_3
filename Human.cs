using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2_indTask
{
    internal class Human : IDate
    {
        public string FullName;
        public string Name;
        public string LastName;
        private int age = 0;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public virtual void OutInfo()
        {
            OutAge();
        }
        
        public void OutAge()
        {
            Console.WriteLine("Возраст: " + Age);
        }

        public Human(string _surname, string _name, string _patronymic, int _age)
        {
            this.FullName = _surname;
            this.Name = _name;
            this.LastName = _patronymic;
            this.Age = _age;
        }

        public void OutAge(int day, int month, int year)
        {
            CalculateAge(day, month, year);
            OutAge();
        }
        public void CalculateAge(int day, int month, int year)
        {
            try
            {
                DateTime birthDate = new DateTime(year, month, day);
                DateTime today = DateTime.Today;
                int age = today.Year - birthDate.Year;
                if (birthDate > today.AddYears(-age))
                {
                    --age;
                }
                Age = age;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
