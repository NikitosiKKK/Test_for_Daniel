using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Endpoins.Models;

namespace Endpoins.Mocks
{
    public static class MapText
    {
        public static List<TextModel> Maps(List<TextModelDB> _text)
        {
            var texts = new List<TextModel>();
            foreach (var text in _text)
            {
                var textModel = new TextModel();
                textModel.Purchases=text.Purchases;
                textModel.Price=text.Price;
                textModel.Rating = text.Rating;
                textModel.AuthorId=text.AuthorId;
                textModel.Date = text.Date;
                textModel.Name=text.Name;
                textModel.Size=text.Size;
                textModel.Content=text.Content;
                texts.Add(textModel);
            }
            return texts;

        }
    }
}

