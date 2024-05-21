using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Domain;

namespace LibraryManagement.Infrastructure.Repositories
{
    internal class AuthorRepository : IAuthorRepository
    {
        private readonly IAppDbContext _appDbContext;

        public AuthorRepository(IAppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAuthor(Author author)
        {
            _ = _appDbContext.Authors!.Add(author);

            await _appDbContext.SaveChangesAsync(default);
        }

        public Task UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
