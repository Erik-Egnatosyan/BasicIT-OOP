namespace GenericsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5;
            string x = "hello", y = "world";
            Console.WriteLine($"a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a = {x}, b = {y}");
            Console.WriteLine();
            Console.WriteLine($"a = {a}, b = {b}");
            Swap(ref x, ref y);
            Console.WriteLine($"a = {x}, b = {y}");

            //---------------------------------------

            // Создаем обобщенный список типа int
            List<int> intList = new List<int>();

            // Добавляем элементы в список
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            // Выводим элементы списка
            foreach (int i in intList)
            {
                Console.WriteLine(i);
            }

            // Создаем обобщенный список типа string
            List<string> stringList = new List<string>();

            // Добавляем элементы в список
            stringList.Add("one");
            stringList.Add("two");
            stringList.Add("three");

            // Выводим элементы списка
            foreach (string s in stringList)
            {
                Console.WriteLine(s);
            }
            //---------------------------------


            // Создаем список объектов типа Person
            List<Person> persons = new List<Person>
            {
                // Добавляем объекты в список
                new Person("Иван", "Иванов", 25),
                new Person("Петр", "Петров", 25),
                new Person("Сидор", "Сидоров", 25)
            };

            // Выводим объекты из списка
            foreach (Person p in persons)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.Age);
            }

            Console.ReadKey();
        }
        static void Swap<T>(ref T a, ref T b)
        {
            (a, b) = (b, a);
        }
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }
        }
    }
}