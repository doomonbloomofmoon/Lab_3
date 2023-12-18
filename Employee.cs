using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_indTask
{
    internal class Employee : Human
    {
        public string Position = "";
        public int WorkExperience = 0;
        public int workExperience
        {
            get
            {
                return workExperience;
            }
            set
            {
                if (workExperience < 0)
                {
                    workExperience = 0;
                }
                else
                {
                    workExperience = value;
                }
            }
        }

        public override void OutInfo()
        {
            base.OutInfo();
            OutWorkExperience();
            OutPositions();
        }
        public void OutWorkExperience()
        {
            Console.WriteLine("Стаж работы: " + WorkExperience);
        }
        public void OutPositions()
        {
            Console.Write("Должность: ");
            bool isEmpty = Position == "" ? true : false;
            if (isEmpty)
            {
                Console.WriteLine("отсутствует");
            }
            else 
            {
                Console.WriteLine(Position);
            }
        }

        public Employee(string _surname, string _name, string _patronymic, int _age) : base(_surname, _name, _patronymic, _age) { }
    }
}

