using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassRoom.Model;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasseRum førsteKlasse = new KlasseRum();
            førsteKlasse.ClassName = "3B";
            førsteKlasse.SemesterStart = DateTime.Now;

            førsteKlasse.ClassList = new List<Student>();
            førsteKlasse.ClassList.Add(new Student("Hakan", 3, 27));
            førsteKlasse.ClassList.Add(new Student("Patrick", 1, 1));

            foreach (var student in førsteKlasse.ClassList)
            {
                Console.WriteLine(student);
            }

           


            Console.ReadKey();
        }
    }
}
