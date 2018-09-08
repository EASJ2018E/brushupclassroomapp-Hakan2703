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

            Student elevEt = new Student("Anouar", 2, 6);
            Student elevTo = new Student("Hakan",3,27);
            Student elevTre = new Student("Sæve", 22, 10);

            førsteKlasse.ClassList.Add(elevEt);
            førsteKlasse.ClassList.Add(elevTo);
            førsteKlasse.ClassList.Add(elevTre);
            elevEt.season();
            elevTo.season();
            elevTre.season();

            foreach (var student in førsteKlasse.ClassList)
            {
                Console.WriteLine(student);
            }

           
            
           


            Console.ReadKey();
        }
    }
}
