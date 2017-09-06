using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstract Class Example
            //Dog dog = new Dog();
            //classAbstract pet = dog;
            //pet.eat();
            //pet.sound();
            //dog.eat();
            //dog.sound();
            //Console.ReadLine();

            //Inheritance Example
            //Tyre tyre = new Tyre();
            //tyre.TyreType();
            //Car car = new Car();
            //car.CarType();
            //car.TyreType();
            //Scooter scooter = new Scooter();
            //scooter.ScooterType();
            //scooter.TyreType();
            //Console.ReadLine();

            //Overloading Example
            //Calculator calc = new Calculator();
            //calc.Sum();
            //calc.Sum(1, 2);
            //calc.Sum(1.8f, 3.6f);
            //calc.Sum("ABC", "DEF");
            //Console.ReadLine();

            //Overriding Example
            BaseClass baseClass = new BaseClass();
            baseClass.MyMethod();
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.MyMethod();
            BaseClass basec = new DerivedClass();
            basec.MyMethod();
            Console.ReadLine();

        }
    }
}
