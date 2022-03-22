create procedure sp_AddingBooks
  
 @BookName varchar(50),
 @AuthorName varchar(50),
 @DiscountPrice money,
  @OriginalPrice money,
  @BookDescription varchar(50),
  @Rating float,
  @Image varchar(50),
  @Reviewer int,
  @BookCount int
  As 
  Begin
  Insert into Books (BookName,AuthorName,DiscountPrice,OriginalPrice,BookDescription,
  Rating,Image,Reviewer,BookCount) values (@BookName,@AuthorName,@DiscountPrice,@OriginalPrice,@BookDescription,
  @Rating,@Image,@Reviewer,@BookCount)
  End

  create procedure sp_UpdateBooks
  @BookId int,
  @BookName varchar(50),
 @AuthorName varchar(50),
 @DiscountPrice money,
  @OriginalPrice money,
  @BookDescription varchar(50),
  @Rating float,
   @Image varchar(50),
  @Reviewer int,
  @BookCount int
  As 
  Begin
  update Books set BookName=@BookName,AuthorName=@AuthorName,DiscountPrice=@DiscountPrice,
  OriginalPrice=@OriginalPrice,BookDescription=@BookDescription,Rating=@Rating,Reviewer=@Reviewer,
  BookCount=@BookCount,Image=@Image where BookId=@BookId
  End
  
  create procedure sp_DeleteBooks
  @BookId int
  As
  Begin
  delete Books where BookId=@BookId
  End
  create procedure sp_GetAllBooks
  As
  Begin
  select * from Books
  End
  create procedure sp_GetAllBookById
  @BookId int
  As
  Begin
  select * from Books where BookId=@BookId
  End