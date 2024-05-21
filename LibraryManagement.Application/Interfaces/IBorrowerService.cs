using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Application.BorrowerItems.Dtos;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.Interfaces
{
    public interface IBorrowerService
    {
        public Task<BorrowerDto> CreateBorrower(BorrowerDto  borrower);
        public Task<BorrowerDto> UpdateBorrower(BorrowerDto borrower);
        public Task<bool> DeleteBorrower(Guid id);
        public Task<Borrower> GetBorrower(Guid id);
    }
}
