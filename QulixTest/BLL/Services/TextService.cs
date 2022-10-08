using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces;
using BLL.Maps;
using BLL.Models;
using DAL.Interfaces;

namespace BLL.Services
{
    public class TextService : ITextService
    {
        private readonly ITextRepository _textRepository;

        public TextService(ITextRepository textRepository)
        {
            _textRepository = textRepository;
        }

        public List<TextModel> List()
        {
            var textEntities = _textRepository.GetAllText();
            var textModels = textEntities.Select(t => TextMap.Map(t));
            return textModels.ToList();
        }
    }
}