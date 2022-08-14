using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using BLL.Models;
using BLL.Maps;

namespace BLL.Services
{
    public class TextService:ITextService
    {
        private readonly ITextRepository _textRepository;
        public TextService(ITextRepository textRepository)
        {
            _textRepository= textRepository; 
        }

        public List<TextModel> GetAllText()
        {
            return TextMap.Maps(_textRepository.GetAllText()) ;
        }

        public void TextAll()
        {
            throw new NotImplementedException();
        }
    }
}
