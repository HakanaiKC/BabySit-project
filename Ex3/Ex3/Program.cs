using System;
using System.Collections;
using System.Collections.Generic;
using static Ex3.Program;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //Person[] array = new Person[3]; 
            //for (int i = 0; i < 3; i++)
            //{
            //    array[i] = new Person
            //    {
            //        Name = Console.ReadLine()
            //    };
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(array[i].ToString());
            //}
            #endregion
            #region ex2
            //Person p = new Person();
            //p.Greet();

            //Student s = new Student();
            //s.SetAge(21);
            //s.Greet();
            //s.ShowAge();
            //s.Study();

            //Teacher t = new Teacher();
            //t.SetAge(30);
            //t.Greet();
            //t.Explain();
            #endregion
            #region ex3
            //Car c = new Car(0);
            //int fuel = int.Parse(Console.ReadLine());
            //if (c.Refuel(fuel))
            //{
            //    c.Drive();
            //}
            #endregion
            #region ex4
            //Dog dog = new Dog();
            //dog.SetName(Console.ReadLine());
            //dog.Eat();
            #endregion
        }
        public interface IVehiculo
        {
            void Drive();
            bool Refuel(int amount);
        }

    }
    #region ex1
    //class Person
    //{
    //    private string name;

    //    public string Name { get => name; set => name = value; }

    //    public override string ToString()
    //    {
    //        return $"Hello! My name is {Name} ";
    //    }
    //}
    #endregion
    #region ex2
    //class Student : Person
    //{
    //    public void Study()
    //    {
    //        Console.WriteLine("I'm studying");
    //    }
    //    public void ShowAge()
    //    {
    //        Console.WriteLine("My age is: {0} years old", age);
    //    }
    //}
    //class Teacher : Person
    //{
    //    public void Explain()
    //    {
    //        Console.WriteLine("I'm explaining");
    //    }
    //}
    //class Person
    //{
    //    public int age;
    //    public void Greet()
    //    {
    //        Console.WriteLine("Hello!");
    //    }
    //    public void SetAge(int n)
    //    {
    //        age = n;
    //    }
    //}
    #endregion
    #region ex3
    class Car : IVehiculo
    {
        public int Fuel { get; set; }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Can't drive");
            }
        }

        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
        
    }
    #endregion
    #region ex4
    //public abstract class Animal
    //{
    //    private string Name;

    //    public void SetName(string name)
    //    {
    //        Name = name;
    //    }

    //    public string GetName()
    //    {
    //        return Name;
    //    }
    //    public abstract void Eat();
    //}
    //public class Dog : Animal
    //{
    //    public override void Eat()
    //    {
    //        Console.WriteLine("Eating");
    //    }
    //}
    #endregion
}
