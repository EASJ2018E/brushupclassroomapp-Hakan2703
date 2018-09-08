using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom.Model
{
    class Student
    {
        public Student(string name, int birthmonth, int birthday)
        {
            Name = name;
            Birthmonth = birthmonth;
            Birthday = birthday;
        }

        public string Name { get; }
        public int Birthmonth { get; }
        public int Birthday { get; }
        public string Season { get; set; }
        

        public string season()
        {
            if (Birthmonth < 13 && Birthmonth > 0)
            {


                if (Birthmonth == 12 || Birthmonth == 1 || Birthmonth == 2)
                {
                    Season = "Winter";
                }

                if (Birthmonth == 3 || Birthmonth == 4 || Birthmonth == 5)
                {
                    Season = "Spring";
                }

                if (Birthmonth == 6 || Birthmonth == 7 || Birthmonth == 8)
                {
                    Season = "Summer";
                }
                else
                {
                    Season = "Fall";
                }

            }
            else
            {
                Console.WriteLine("Et af fødselsdagene er ikke indtaststet korrekt for en elev" );
                return Season = "fejl";
            }

            return Season;
          
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Birthmonth)}: {Birthmonth}, {nameof(Birthday)}: {Birthday}, {nameof(Season)}: {Season}";
        }
    }
}
