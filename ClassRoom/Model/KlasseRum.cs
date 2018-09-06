using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom.Model
{
    class KlasseRum
    {

        public KlasseRum()
        {
            
        }

        public string ClassName { get; set; }
        public List<Student> ClassList { get; set; }
        public DateTime SemesterStart { get; set; }


        public override string ToString()
        {
            return $"{nameof(ClassName)}: {ClassName}, {nameof(ClassList)}: {ClassList}, {nameof(SemesterStart)}: {SemesterStart}";
        }
    }
}
