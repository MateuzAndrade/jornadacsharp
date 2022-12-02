using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBaltaOrientacaoObjetos.ContentContext
{
    public class Carrer : Content
    {
        public Carrer()
        {
            Items = new List<CareerItem>();
        }
        
        
        public IList<CareerItem> Items;
    }

}