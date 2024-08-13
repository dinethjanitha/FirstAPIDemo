using FirstAPI.DataAccess;
using FirstAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPI.Services.Authors
{
    public class AuthorSqlService : IAuthorRepo
    {
        public readonly TodoDbContex _context = new TodoDbContex();
        public List<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.Find(id);
        }
    }
}
