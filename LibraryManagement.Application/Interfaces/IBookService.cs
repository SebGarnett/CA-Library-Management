using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Application.BookItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBookService
    {
        public Task<BookDto> CreateBook(BookDto book);
        public Task<BookDto> UpdateBook(Book book);
        public Task<bool> DeleteBook(Guid id);
        public Task<Book> GetBook(Guid id);
    }
}
