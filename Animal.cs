using System;

public class Animal {
    public void MakeSound() {
        Console.WriteLine("Some Generic Sound")
    }

    public class Dog : Animal {
        public override void MakeSound() {
            Console.WriteLine("Bark")
        }
    }
}