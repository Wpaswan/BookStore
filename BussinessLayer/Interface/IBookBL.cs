using CommonLayer.PostModel;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BussinessLayer.Interface
{
    public interface IBookBL
    {
        string AddBooks(BookPostModel addBook);
        bool UpdateBooks(int BookId, BookPostModel updateBook);
        bool DeleteBook(int BookId);
        List<BookModel> GetAllBooks();
        List<BookPostModel> GetBookByBookId(int BookId);

    }
}
