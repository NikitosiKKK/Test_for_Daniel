using DAL.Entities;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ITextRepository
    {
        public List<TextEntity> GetAllText();
    }
}
