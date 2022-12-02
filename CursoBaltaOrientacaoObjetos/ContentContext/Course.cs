using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoBaltaOrientacaoObjetos.ContentContext.Enums;

namespace CursoBaltaOrientacaoObjetos.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }
        public string? Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }

}