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
            Student elevNummerEt = new Student("Hakan", 3,27);
            Student eleverNummerto = new Student("Patrick",1,1);


            førsteKlasse.ClassName = "3B";
            førsteKlasse.SemesterStart = DateTime.Now;

            førsteKlasse.ClassList.Add(elevNummerEt);
            førsteKlasse.ClassList.Add(eleverNummerto);


        }
    }
}
