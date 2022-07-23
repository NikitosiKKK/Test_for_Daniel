using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endpoins.Models
{
    public class TextModel
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Size { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }
        public int Purchases { get; set; }
        public int Rating { get; set; }
    }
}
