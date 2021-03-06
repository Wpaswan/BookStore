using CommonLayer.PostModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Entity
{
    public class CartModel
    {
        public int CartID { get; set; }
        public int userId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public BookPostModel bookModel { get; set; }
    }
}
