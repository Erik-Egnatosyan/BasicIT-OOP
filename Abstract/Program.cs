﻿namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            cat.Eat();
            dog.Eat();
            //Абстрактный класс в C# - это класс, который содержит один
            //или несколько абстрактных методов и не может быть создан напрямую.
            //Абстрактный метод в C# - это метод, который не имеет реализации в базовом классе.
            //Он определяет только сигнатуру метода, которую должны реализовать его наследники. 
        }
    }
}