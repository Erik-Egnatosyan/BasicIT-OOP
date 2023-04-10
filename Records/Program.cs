namespace Records
{
    internal class Program
    {
        // Определение класса Date как Record с тремя свойствами
        public record Date(int Year, int Month, int Day);

        // Определение класса Person как Record с тремя свойствами
        public record Person(string FirstName, string LastName, int Age);

        static void Main(string[] args)
        {
            // Создание объекта класса Date
            Date date = new Date(2023, 3, 31);

            // Создание списка объектов класса Person
            List<Person> list = new List<Person>
            {
                new Person("Erik", "Egnatosyan", 19),
                new Person("Suren", "Egnatosyan", 17),
                new Person("Alex", "Egnatosyan", 29),
                new Person("asfsdf", "Egnatosyan", 89),
                new Person("sdgfsg", "Egnatosyan", 94),
                new Person("sdgsdg", "Egnatosyan", 51),
            };

            // Вывод значения объекта date в консоль
            Console.WriteLine(date);

            // Вывод значений свойств каждого объекта типа Person в списке
            foreach (Person person in list)
            {
                Console.WriteLine(person);
            }
        }

    }
}