using Entities.Concrates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IBookService
    {
        public IEnumerable<Book> GetList();
        public Book GetById(Guid id);
        public void Add(Book book);


    }
}
