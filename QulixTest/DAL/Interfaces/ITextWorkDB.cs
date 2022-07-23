using DAL.Models;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ITextWorkDB
    {
        public List<TextModelDB> GetAllText();

    }
}
