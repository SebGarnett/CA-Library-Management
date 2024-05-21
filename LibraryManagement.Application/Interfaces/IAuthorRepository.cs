using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces
{
    public interface IAuthorRepository
    {
        public Task AddAuthor(Author author);
        public Task UpdateAuthor(Author author);
        public Task RemoveAuthor(Author author);
        public Task<Author> GetAuthorById(Guid id);
        
    }
}
