using System;

public class Animal {
    public void MakeSound() {
        Console.WriteLine("Some Generic Sound");
    }

    public class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Bark");
        }
    }

    public class Cat : Animal {
        public override void MakeSound () {
            Console.WriteLine("Meow");
        }
    }
}


public class Main 
{
  public static void Main(string[] args)
  {
    Animal animal = new Animal();
    animal.MakeSound(); 

    Dog dog = new Dog();
    dog.MakeSound();

    Cat cat = new Cat();
    cat.MakeSound(); 
  }
}