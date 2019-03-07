﻿using System;

namespace Pets
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);

            Console.WriteLine("Name: " + pet1.petName);
            Console.WriteLine("Weight: " + pet1.petWeight);
            Console.WriteLine(pet1.getTag());

            Dog dog1 = new Dog("Daisy", "Kent", 23.4);

            Console.WriteLine("Name: " + dog1.petName);
            Console.WriteLine("Weight: " + dog1.petWeight);
            Console.WriteLine(dog1.getTag());
            Console.WriteLine(dog1.bark(4));
        }
    }
}