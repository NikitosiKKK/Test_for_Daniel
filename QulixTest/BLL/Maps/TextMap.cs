using BLL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Maps
{
    public static class TextMap
    {
        public static List<TextModel> Maps(List<TextEntity> _text)
        {
            var texts = new List<TextModel>();
            foreach (var text in _text)
            {
                var textModel = new TextModel();
                textModel.Purchases = text.Purchases;
                textModel.Price = text.Price;
                textModel.Rating = text.Rating;
                textModel.AuthorId = text.AuthorId;
                textModel.Date = text.Date;
                textModel.Name = text.Name;
                textModel.Size = text.Size;
                textModel.Content = text.Content;
                texts.Add(textModel);
            }
            return texts;

        }
    }
}
