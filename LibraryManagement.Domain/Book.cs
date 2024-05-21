using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Domain
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Available { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
