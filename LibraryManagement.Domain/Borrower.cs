using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain
{
    public class Borrower
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
