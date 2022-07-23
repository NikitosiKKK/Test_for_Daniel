using Endpoins.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endpoins.Interfaces
{
    public interface ITextWork
    {
        public List<TextModel> GetAllText();
        public void TextAll();
    }
}
