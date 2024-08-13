using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstAPI.DataAccess;

namespace FirstAPI.Services.Authors
{
    public interface IAuthorRepo
    {
        public List<Author> GetAllAuthors();
        public Author GetAuthor(int id);
    }
}
