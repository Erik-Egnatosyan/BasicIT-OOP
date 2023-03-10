using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class DoctorAssistant:Doctor
    {
        public void _DoctorAssist()
        {
            Console.WriteLine(Name);
        }
        public short AssistantAge { get; set; }

        public DoctorAssistant()
        {
            
        }
    }
}
