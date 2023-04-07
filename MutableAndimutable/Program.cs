namespace MutableAndimutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MutableClass mutable = new MutableClass();
            mutable.Value = 42;
            Console.WriteLine("Initial mutable value: " + mutable.Value);

            ImmutableClass immutable = new ImmutableClass(42);
            Console.WriteLine("Initial immutable value: " + immutable.GetValue());

            mutable.Value = 24;
            Console.WriteLine("Changed mutable value: " + mutable.Value);

            // Попытка изменить значение свойства immutable.Value приведет к ошибке компиляции,
            // так как это свойство доступно только для чтения.
            //immutable.Value = 24;

            Console.WriteLine("Unchanged immutable value: " + immutable.GetValue());

        }
        class MutableClass
        {
            public int Value { get; set; }
        }
        class ImmutableClass
        {
            private readonly int value;

            public ImmutableClass(int value) => this.value = value;

            public int GetValue()
            {
                return value;
            }
        }
    }
}