namespace Inheritance
{
    internal class Doctor : HumanBase
    {
        public short y;
#pragma warning disable CS0649 // Полю "Doctor.v" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию 0.
        public short v;
#pragma warning restore CS0649 // Полю "Doctor.v" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию 0.
        public void Testmethod()
        {
            Name = "Elizaveta Vachaganovna";
            Age = y;
            //publicHelloMen();
            //internalByMen();  
            //protectedWhyMen();
            //_privateWhyMen()
        }
        public Doctor() : base()
        {
        }
        public Doctor(short t) : base(t)
        {
            this.y = t;
            //this.v = base.Age;
        }
    }
}
