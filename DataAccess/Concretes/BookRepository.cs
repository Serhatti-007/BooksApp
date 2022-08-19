using DataAccess.Context;
using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class BookRepository
    {
        private BookContext DbContext { get; set; }


        public List<Book> GetList()
        {
            return DbContext.Books.ToList();
        }

        public void Add(Book book)
        {
            DbContext.Books.Add(book);



        }






    }
}
