using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    public class Person
    {
        string _name;
        int _age;
        int _height;
        int _salary;

        public Person(string name, int age, int height, int salary)
        {
            _name = name;
            _age = age;
            _height = height;
            _salary = salary;

        }
        public string Name => $"{_name}";
        public string Age => $"{_age}";
        public string Height => $"{_height}";

        public void ChangeAge(int value)
        {
            _age = value;
        }


        public void SetHeight(int newvalue)
        {
            this._height = newvalue;
        }

        public void CompareHeight(Person value)
        {
            if (this._height > value._height)
            {
                Console.WriteLine($"First person({this._height}) is taller than second person({value._height})");
            }
            else
            {
                Console.WriteLine($"Second person({value._height}) is taller than first person({this._height})");
            }
        }
        public static void CompareHeight2(Person value, Person value2)
        {
            if (value._height > value2._height)
            {
                Console.WriteLine($"First person({value._height}) is taller than second person({value2._height})");
            }
            else
            {
                Console.WriteLine($"Second person({value2._height}) is taller than first person({value._height})");
            }
        }
        public void IncreaseSalary(int value)
        {
            if (this._salary < 1500)
            {
                this._salary += value;
                Console.WriteLine($"{this._name}'s salary is now {this._salary}");
            }
            else
            {
                Console.WriteLine($"{this._name}'s salary is already high enough");
            }
        }
        public void PrintSalary()
        {
            Console.WriteLine($"{this._name}'s salary is {this._salary}");
        }
    }

    class TestPerson
    {
        public static void Main()
        {
            Person Alex = new Person("Alex", 24, 178, 1000);
            Person Mark = new Person("Mark", 17, 168, 500);
            Console.WriteLine($"{Alex.Name} is {Alex.Age}");
            Alex.ChangeAge(12);
            Console.WriteLine($"{Alex.Name} is {Alex.Age}");
            Alex.CompareHeight(Mark);
            Mark.SetHeight(192);
            Alex.CompareHeight(Mark);
            Person.CompareHeight2(Alex, Mark);
            Alex.PrintSalary();
            Alex.IncreaseSalary(1000);
            Alex.IncreaseSalary(1000);

        }
    }
}   






