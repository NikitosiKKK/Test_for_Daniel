using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endpoins.Models
{
    public class SearchPhoto
    {

        public List<PhotoModel> Photos{ get; set; }
        public PageSettings Paging { get; set; }
    }
}
