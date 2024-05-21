using System.ComponentModel.DataAnnotations;
using LibraryManagement.API.Models;
using LibraryManagement.Application.AuthorItems.Dtos;
using LibraryManagement.Application.BookItems.Dtos;
using LibraryManagement.Application.BorrowerItems.Dtos;
using LibraryManagement.Application.Interfaces;
using LibraryManagement.Application.LoanItems.Dtos;
using Microsoft.AspNetCore.Mvc;
//using LibraryManagement.Application.Services;

namespace LibraryManagement.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class LibraryManagementController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        private readonly IBorrowerService _borrowerService;
        private readonly ILoanService _loanService;

        public LibraryManagementController(IAuthorService authorService, IBookService bookService, IBorrowerService borrowerService, ILoanService loanService)
        {
            _authorService = authorService;
            _bookService = bookService;
            _borrowerService = borrowerService;
            _loanService = loanService;
        }

        [HttpPost("/author/createAuthor")]
        public async Task<ObjectResult> CreateAuthor(CreateAuthorRequest request)
        {
            try
            {
                var command = new AuthorDto
                {
                    Name = request.Name
                };
                var result = await _authorService.CreateAuthor(command);
                return new OkObjectResult(result);
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("/book/createBook")]
        public async Task<ObjectResult> CreateBook(CreateBookRequest request)
        {
            try
            {
                var command = new BookDto
                {
                    Name = request.Name,
                    AuthorId = request.AuthorId
                };
                return new OkObjectResult(await _bookService.CreateBook(command));
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("/borrower/createBorrower")]
        public async Task<ObjectResult> CreateBorrower(CreateBorrowerRequest request)
        {
            try
            {
                var command = new BorrowerDto
                {
                    Name = request.Name
                };
                return new OkObjectResult(await _borrowerService.CreateBorrower(command));
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("/loan/createLoan")]
        public async Task<ObjectResult> CreateLoan(CreateLoanRequest request)
        {
            try
            {
                var command = new LoanDto
                {
                    BookId = request.BookId,
                    BorrowerId = request.BorrowerId,
                    LoanDate = request.LoanDate,
                    EndDate = request.EndDate
                };
                return new OkObjectResult(await _loanService.CreateLoan(command));
            }
            catch (ValidationException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
