using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpangenbergProject.Models.Blogg
{
    public class BloggModel
    {
        public int BlogId { get; set; }
        public string HeadLine { get; set; }
        public string TextWindow { get; set; }
        public DateTime BDtm { get; set; }
    }
}
