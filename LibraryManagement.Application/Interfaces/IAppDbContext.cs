using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace LibraryManagement.Application.Interfaces
{
    public interface IAppDbContext
    {
        public DbSet<Author>? Authors { get; set; }
        public DbSet<Book>? Books { get; set; }
        public DbSet<Borrower>? Borrowers { get; set; }
        public DbSet<Loan>? Loans { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
