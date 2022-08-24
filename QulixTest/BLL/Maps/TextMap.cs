using BLL.Models;
using DAL.Entities;

namespace BLL.Maps
{
    public static class TextMap
    {
        public static TextModel Map(TextEntity textEntity)
        {
            var textModel = new TextModel
            {
                Id = textEntity.Id,
                Purchases = textEntity.Purchases,
                Price = textEntity.Price,
                Rating = textEntity.Rating,
                AuthorId = textEntity.AuthorId,
                Date = textEntity.Date,
                Name = textEntity.Name,
                Size = textEntity.Size,
                Content = textEntity.Content
            };
            return textModel;
        }
    }
}
