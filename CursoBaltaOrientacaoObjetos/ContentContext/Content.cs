using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoBaltaOrientacaoObjetos.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }  
                
    }
}