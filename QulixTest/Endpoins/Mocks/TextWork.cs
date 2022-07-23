using DAL.Interfaces;
using Dapper;
using Endpoins.Interfaces;
using Endpoins.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endpoins.Mocks
{
    public class TextWork:ITextWork
    {
        private ITextWorkDB _textWork;


        public TextWork(ITextWorkDB textWork)
        {
            _textWork = textWork;

        }
        public List<TextModel> GetAllText() {
            return MapText.Maps(_textWork.GetAllText());
        }
        public void TextAll() {
            List<TextModel> text;
            string inf="";
            string filePath = "D://works/qulix-test-main/text/text.txt";
            FileStream fileStream = File.Open(filePath, FileMode.Create);
            text = MapText.Maps(_textWork.GetAllText());
            foreach (TextModel textModel in text) {
                inf = String.Format("{0}\nAuthorId:{1}\tName:{2}\tContent:{3}\tSize:{4}\tDate:{5}\tPrice:{6}\tPurchases:{7}\tRating:{8}", inf, textModel.AuthorId.ToString(), textModel.Name.ToString(), textModel.Content.ToString(), textModel.Size.ToString(), textModel.Date.ToString(), textModel.Price.ToString(), textModel.Purchases.ToString(), textModel.Rating.ToString());
            }
            StreamWriter output = new StreamWriter(fileStream);
            output.Write(inf);
            output.Close();

        }
    }
}
