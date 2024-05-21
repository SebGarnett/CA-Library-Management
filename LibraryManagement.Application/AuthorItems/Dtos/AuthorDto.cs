using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Application.Services;
using LibraryManagement.Domain;

namespace LibraryManagement.Application.AuthorItems.Dtos
{
    public class AuthorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
