using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.EntityFrameworkDataAccess;
using LibraryManagement.Pocos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LibraryMangement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryManagementController : ControllerBase
    {
        private readonly LibraryManagementContext _context;
        public LibraryManagementController()
        {
            _context = new LibraryManagementContext();
        }

        //Update user database
        [HttpPost]
        [Route("postuser")]
        public ActionResult PostUser([FromBody] UsersPoco poco)
        {
            _context.UsersPocos.Add(poco);
            _context.SaveChanges();
            return Ok();
        }

        //Update book database
        [HttpPost]
        [Route("postbook")]
        public ActionResult PostBook([FromBody] BookPoco poco)
        {
            _context.BookPoco.Add(poco);
            _context.SaveChanges();
            return Ok();
        }

        //Allow users to browse books
        [HttpGet]
        [Route("books")]
        public ActionResult GetBooks()
        {
            List<BookPoco> Books = _context.BookPoco.ToList();

            if (Books != null)
            {
                return Ok(Books);
            }
            else
            {
                return NotFound();
            }
        }


        //Allow users to check out books
        [HttpPut]
        [Route("checkout/{userid}/{bookid}")]
        public ActionResult Checkout(Guid userid, Guid bookid)
        {
            BookPoco book = _context.BookPoco.First(b => b.Id == bookid);
            UsersPoco user = _context.UsersPocos.First(u => u.Id == userid);

            book.User = user;
            _context.SaveChanges();
            return Ok();
        }

        //Allow library staff to see what books are checked out
        [HttpGet]
        [Route("getcheckedoutbooks")]
        public ActionResult GetCheckedOutBooks()
        {
            List<BookPoco> books = _context.BookPoco.Where(b => b.User != null).ToList();

            if (books != null)
            {
                return Ok(books);
            }
            else
            {
                return NotFound();
            }
        }
    }
}