namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctorParam = new Doctor(8);
            doctorParam.Testmethod();
            Console.WriteLine(doctorParam.Age + " doctorParam");
            HumanBase human = new HumanBase();
            Console.WriteLine(human.Age + "     ageHuman");
            DoctorAssistant assistant = new DoctorAssistant();
            assistant.Name = "Ero eho";
            assistant._DoctorAssist();
        }
    }
}