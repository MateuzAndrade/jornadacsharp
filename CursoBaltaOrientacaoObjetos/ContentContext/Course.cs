using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBaltaOrientacaoObjetos.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            
        }
        public string? Tag { get; set; }
        public IList<Module>? Modules { get; set; }       

    }
    public class Module
    {
        public int Order { get; set; }
        public string? Title { get; set; }       
        
    }

    public class Lecture
    {
        
    }
}