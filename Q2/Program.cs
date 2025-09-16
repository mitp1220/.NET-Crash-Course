using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// OPPS Concept
//namespace Q2
//{
//    class Vehicle
//    {
// Inheritance

// write a c# program to demonstrate the concept of,
// inheritance and method overriding.

// a) create a base class named vehicle with data members to store the make(brand)
// and year of manufacture.
// b) create a derived class car that inherits from vehicle and
// has an additional data member for the model.
// c) both classes should have a method ShowInfo() to display their details.
// use constructor chamgIn() to initialize base class members from the derived class.
// In the main method, create an object of car and dislpay a complete info of vehicle.
//        public string Make {  get; set; }
//        protected int year;
//        public Vehicle(string make, int year)
//        {
//            Make = make;
//            this.year = year;
//        }
//        public virtual void ShowInfo()
//        {
//            Console.WriteLine($"Vehicle:{Make},Year:{year}");
//        }
//    }
//    class Car : Vehicle
//    {
//        public string Model { get; set; }
//        public Car(string make, int year, string model) : base(make, year)
//        {
//            Model = model;
//        }
//        public override void ShowInfo()
//        {
//            base.ShowInfo();
//            Console.WriteLine($"Model:{Model}");
//        }
//    }

//    class Program 
//    {
//        
//        {
//            Car c = new Car("Nissan", 2020, "GTR R35");
//            c.ShowInfo();
//              Console.ReadKey();
//        }
//    }
//}

// write a c# program where animal is a base class (with a method Eat()) and
// dog is a derived class (add bark). Create a dog object and
// demonstrate that it can use both methods.


// POLYMORPHISM

// EX-1
//write a c# program that shows polymorphism using shapes.
// a) create a base class Shape with a virtual method Draw().
// b) Derive two classes rectangle and circle that override Draw().
// c) in main call draw method using a shape referrance pointing to
// different derived objects.

//public class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Drawing a shape");
//    }
//}
//public class Rectangle:Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a rectangle");
//    }
//}
//public class Circle:Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Drawing a circle");
//    }
//}
//class program
//{
//    static void Main(string[] args)
//    {
//        Shape s;
//        s = new Rectangle();
//        s.Draw();

//        s = new Circle();
//        s.Draw();
//        Shape[] shapes = new Shape[]
//        {
//            new Shape(), new Rectangle(), new Circle()
//        };
//        foreach(Shape sh in shapes)
//        {
//            sh.Draw();
//        }
//    }
//}

// write a c# console program that demonstrates runtime polymorphism,
// create a base class animal with a virtual method speak() then create dog and cat classes
// that overrides speak, to show that the actual runtime type determines while Speak() runs.

//public class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine("both animals are speaking");
//    }
//}
//public class Dog:Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("Dog is barking");
//    }
//}
//public class Cat:Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("cat is speaking");
//    }
//}
//class program
//{
//    static void Main(string[] args)
//    {
//        Animal s;
//        s = new Dog();
//        s.Speak();

//        s = new Cat();
//        s.Speak();
//        Animal[] animals = new Animal[]
//        {
//            new Animal(), new Dog(), new Cat()
//        };
//        foreach (Animal a in animals)
//        {
//            a.Speak();
//        }
//    }
//}


// ENCAPSULATION
// write a c# program to demonstrate encapsulation by creating a person class.
// the class should keep the age field private and provide public methods (SetAge and GetAge)
// to control how the age is accessed and modified with validation to prevent invalid values.

//class Person
//{
//    private int age;
//    public void SetAge(int a)
//    {
//        if (a >= 0) age = a;
//        else Console.WriteLine("Invalid Age");
//    }
//    public int GetAge()
//    {
//        return age;
//    }
//}
//class Program
//{
//    static void Main(String[] args)
//    {
//        Person p = new Person();
//        p.SetAge(25);
//        Console.WriteLine(p.GetAge());
//        p.SetAge(-5);
//    }
//}

// create a c# program to demonstrate encapsulation by creating a student class
// the class should keep the marks field private and
// provide public methods (SetMarks and GetMarks) to control access,
// ensuring that only values between zero and one hundred are accepted.


// write a c# program to demonstrate encapsulation by creating a student class,
// the class should keep the marks field private and provide public methods (SetMarks & GetMarks)
// to control access, ensuring tht only values between 0-100 are accepted. 

//class Student
//{
//    private int marks;
//    public void SetMarks(int m)
//    {
//        if (m >= 0 && m <= 100) marks = m;
//        else Console.WriteLine("invalid marks");
//    }
//    public int GetMarks()
//    {
//        return marks;
//    }
//}
//class program
//{
//    static void Main(string[] args)
//    {
//        Student S = new Student();
//        S.SetMarks(71);
//        Console.WriteLine(S.GetMarks());
//        S.SetMarks(125);
//    }
//}


// Abstract Class
// write a c# program to demonstrate abstraction by creating an
// abstract class vehicle that declares an abstract method start ng
// derive car and bike from vehicle and implement startengine() in each.
// In main, use the vehicle referrence to call startengine() on different concrete vehicles.

//public abstract class Vehicle
//{
//    public abstract void StartEngine();
//    public void Describe()
//    {
//        Console.WriteLine("This is a vehicle");
//    }
//}

//public class Car:Vehicle
//{
//    public override void StartEngine()
//    {
//        Console.WriteLine("Car engine started");
//    }
//}

//public class Bike : Vehicle
//{
//    public override void StartEngine()
//    {
//        Console.WriteLine("Bike engine started");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Vehicle v = new Car();
//        v.StartEngine();
//        v = new Bike();
//        v.StartEngine();
//        v.Describe();
//    }
//}

// write a c# peogram to demonstrate by creating abstract class employee
// with an abstract method to calculate salary. Derive manager and developer classes
// and implement calculatesalary() method. In main, use an employee reference
// to call claculatesalary() of different employees.

//abstract class Employee
//{
//    public abstract double CalculateSalary();
//}

//class Manager : Employee
//{
//    public override double CalculateSalary()
//    {
//        return 25000;
//    }
//}

//class Developer : Employee
//{
//    public override double CalculateSalary()
//    {
//        return 15000;
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        Employee e;
//        e = new Manager();
//        Console.WriteLine($"Manager salary = {e.CalculateSalary()}");
//        e = new Developer();
//        Console.WriteLine($"Developer salary = {e.CalculateSalary()}");
//    }
//}


// CH-2
// LINQ (Language Integrated Query), it allows user to query collections,
// directly using c# syntax instead of writing loops or sql statement seprarately.

// write a c# program who demonstrate LINQ methods on a list of integers, perform filetring,
// sorting and accessing elements and aggregation using the following methods;
// Where, OrderBy, ElementAdd, ElementAddOrDefault, First, FirstOrDefualt, Last,
// LastOrDefault, Max, Min, Average, Sum, Count.

//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
//        var filtered = numbers.Where(n => n > 20);
//        foreach (var n in filtered)
//        {
//            Console.WriteLine(n);
//        }
//        var sorted = numbers.OrderBy(n => n);
//        Console.WriteLine("Sorted Numbers");
//        foreach (var n in sorted)
//        {
//            Console.WriteLine(n);
//        }
//        Console.WriteLine($"Element at index 2:{numbers.ElementAt(2)}");
//        Console.WriteLine($"Element at index 10 (or default):{numbers.ElementAtOrDefault(10)}");
//        Console.WriteLine($"First Element:{numbers.First()}");
//        Console.WriteLine($"First Or Default:{numbers.FirstOrDefault()}");
//        Console.WriteLine($"Last Element:{numbers.Last()}");
//        Console.WriteLine($"Last Or Defualt:{numbers.LastOrDefault()}");
//        Console.WriteLine($"Maximum value:{numbers.Max()}");
//        Console.WriteLine($"Minimum value:{numbers.Min()}");
//        Console.WriteLine($"Average value:{numbers.Average()}");
//        Console.WriteLine($"Sum of numbers:{numbers.Sum()}");
//        Console.WriteLine($"Count of numbers:{numbers.Count()}");
//    }
//}

// Demonstrate LINQ methods on a list of floating point numbers. Take random 20 floating
// point numbers, perform filtering, sorting and all other operatons as above.



// DELEGATES AND EVENTS

// DELEGATE
// A delegate is like a reference, pointer to method.
// It can hold the address of any method that matches its signature(parameters and return-type).
// It can be invoked directly by any one holding it.
// Types: 1) Single Cast Delegate 
// -> Point to one method 
// 2) Multicast Delegate
// -> points to multiple methods.
// 3) Generic Delegate
// -> (i) Func => retuns a value
// -> (ii) Action => returns void
// -> (iii) Predicate => returns bool

// Events
// An event is a notification mechanism in .NET. 
// A class (publisher) raises an event, and other classes called subscriber respond to it.
// It can only be triggered inside the class where it is defined.
// Events are built on top of delegates.
// Delegates let you call methods indirectly while events let you notify others when something happens


// Create a c# coonsole application that uses Delegates and Events for a traffic monitoring system.
// 1) CLass TrafficSignal with fields location, vehicle_count.
// 2) Method UpdateVehicleCount() with input (int newCount), updates vehicle count.
// 3) Define Delegate + Event TrafficJamAlert.
// 4) Raise event if vehicle count greater than 100.
// 5) In Main() create a TrafficSignal object, subscribe to the event and display a warning message when triggered.

using System;
public delegate void TrafficJamAlert
public class TrafficSignal
{
    public string Location { get; set; }
    public int Vehicle_Count { get; private set; }
    public event TrafficJamAlert OnTrafficJam;
    public TrafficSignal(string location)
    { Location = location; }
    public void UpdateVehicleCount(int newCount)
    {
        Vehicle_Count = newCount;
        Console.WriteLine($"[{Location}] Vehicle count updated {Vehicle_Count}");
        if (Vehicle_Count > 100)
        {
            OnTrafficJam?.Invoke(Location, Vehicle_Count);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        TrafficSignal signal = new TrafficSignal("Karnavati Crossing");
        signal.OnTrafficJam += (loc, count) =>
        {
            Console.WriteLine($"Alert! Traffic Jam at {loc} vehicles:{count}");
        }
        signal.UpdateVehicleCount(80);
        signal.UpdateVehicleCount(100);
        signal.UpdateVehicleCount(120);
    }
}