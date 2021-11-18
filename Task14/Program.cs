using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ANimals:");
            Dog dog1 = new Dog("Bobik");
            dog1.ShowInfo();

            Dog dog2 = new Dog("Шарик");
            dog2.ShowInfo();

            Cat cat = new Cat("Barsik");
            cat.ShowInfo();

            Cat cat2 = new Cat("Murzik");
            cat2.ShowInfo();

            Console.ReadKey();
        }
    }


    abstract class Animal
    {

        public abstract string Name { get; set; }

        public Animal()
        {
            Name = "Безымянный";
        }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.Write("{0}: ", Name);
            Say();
        }

    }

    class Cat : Animal
    {
        public override string Name { get; set; }
        public Cat(string name) :
            base(name)
        { }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }


    class Dog : Animal
    {
        public override string Name { get; set; }

        public Dog(string name) :
            base(name)
        { }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
