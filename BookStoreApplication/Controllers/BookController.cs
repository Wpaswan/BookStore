using BussinessLayer.Interface;
using CommonLayer.PostModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookStoreApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {

        IBookBL bookBL;
        public BookController(IBookBL bookBL)
        {
            this.bookBL = bookBL;

        }
        [Authorize]
        [HttpPost("addbooks")]
        public IActionResult AddBooks(BookPostModel addBooks)
        {
            try
            {
                var userEmail = User.FindFirst("EmailId").Value.ToString();
                if (userEmail != null)
                {
                    var result = this.bookBL.AddBooks(addBooks);
                    if (result.Equals("book added successfully"))
                    {
                        return this.Ok(new { success = true, message = $"Details of Book Added Successfully " });
                    }
                    else
                    {
                        return this.BadRequest(new { Status = false, Message = result });
                    }
                }
                else
                {
                    return BadRequest(new { Success = false, message = "Password reset Unsuccesfully" });
                }
               

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        [Authorize]
        [HttpPut("updatebooks/{BookId}")]
        public IActionResult UpdateBooks(int BookId, BookPostModel updateBooks)
        {
            try
            {
                var userEmail = User.FindFirst("EmailId").Value.ToString();
                if (userEmail != null)
                {
                    var result = this.bookBL.UpdateBooks(BookId, updateBooks);
                    if (result.Equals(true))
                    {
                        return this.Ok(new { success = true, message = $"Book updated Successfully ", response = updateBooks });
                    }
                    else
                    {
                        return this.BadRequest(new { Status = false, Message = result });
                    }
                }
                else
                {
                    return BadRequest(new { Success = false, message = "Book updated Unsuccesfully" });
                }
              

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        [HttpDelete("deletebook/{BookId}")]
        public IActionResult DeleteBook(int BookId)
        {
            try
            {
                var result = this.bookBL.DeleteBook(BookId);
                if (result.Equals(true))
                {
                    return this.Ok(new { success = true, message = $"Book deleted Successfully ", response = BookId });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = result });
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }
        [HttpGet("getallbook")]
        public IActionResult GetAllBooks()
        {
            try
            {
                var result = this.bookBL.GetAllBooks();
                if (result!=null)
                {
                    return this.Ok(new { success = true, message = $"All Books Displayed Successfully ", response = result });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = $"Books are not there " });
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }

        [HttpGet("getallbookbyBookId/{BookId}")]
        public IActionResult GetAllBookByBookId(int BookId)
        {
            try
            {
                var result = this.bookBL.GetBookByBookId(BookId);
                if (result != null)
                {
                    return this.Ok(new { success = true, message = $"Books is  Displayed Successfully by BookId ", response = result });
                }
                else
                {
                    return this.BadRequest(new { Status = false, Message = $"Book id not exists " });
                }

            }
            catch (Exception e)
            {
                throw e;
            }

        }









    }
}
