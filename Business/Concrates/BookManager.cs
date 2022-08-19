using Business.Abstracts;
using DataAccess.Concretes;
using Entities.Concrates;

namespace Business.Concrates
{
    public class BookManager : IBookService
    {
        private BookRepository bookRepo = new BookRepository();


        public Book GetById(Guid id)
        {
            if (id==null)
            {
                return null;
            }
            if (id==null)
            {
                //id boş gönderilmez
            }


        }

        public IEnumerable<Book> GetList()
        {
            if (1==1)
            {
                return bookRepo.GetList().Where(a => a.Name.StartsWith("a"));
            }

            return bookRepo.GetList();
        }

        public void Add(Book book)
        {
            if (book.Name==null)
            {
                return;
            }
            if (book.Id==null)
            {
                book.Id = Guid.NewGuid();
            }

            bookRepo.Add(book);




        }
    }
}
