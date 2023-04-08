namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Полиморфизм через перегрузку методов:
            MyClass obj = new MyClass();
            obj.Method(10); // int: 10
            obj.Method("Hello"); // string: Hello
            //Полиморфизм через наследование:
            Animal[] animals = new Animal[2];
            animals[0] = new Dog();
            animals[1] = new Cat();

            foreach (Animal animal in animals)
            {
                animal.MakeSound();
            }
            // The dog barks
            // The cat meows
        }
        //Плюсы полиморфизма в C#:

        //1)Упрощение кода: использование полиморфизма позволяет сократить количество кода,
        //уменьшить его сложность и сделать его более понятным и читаемым.

        //2)Гибкость: полиморфизм позволяет изменять поведение объектов в зависимости от контекста.
        //Это делает код более гибким и позволяет легко вносить изменения в приложение.

        //3)Расширяемость: благодаря полиморфизму, можно легко добавлять новые функциональности
        //в приложение без изменения существующего кода.

        //4)Повторное использование кода: благодаря полиморфизму можно создавать
        //универсальные классы и методы, которые могут использоваться в различных частях приложения.
        class MyClass
        {
            public void Method(int x)
            {
                Console.WriteLine("int: " + x);
            }

            public void Method(string str)
            {
                Console.WriteLine("string: " + str);
            }
        }
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The dog barks");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("The cat meows");
            }
        }
    }
}