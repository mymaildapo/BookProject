using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Summary description for ProductModel
/// </summary>
namespace Models
{   //first model done
    // ProductModel,ProductTypeModel AND CartModel all done because of Admin Page
    public class ProductModel
    {
    
        public string InsertProduct(BookTB product)
        {
            //we workin on table in sql call BookTB
            //(BookTB product) product object, this is used foreach statement
            try
            {
                //BookTB in model.tt>model.cs (booktb get{ })
                BookDBEntities1 db = new BookDBEntities1();
                //check web confiq to see ur entity name u created tru ado.net entity
                db.BookTBs.Add(product);
                //BookTBs in Model.Context.tt >Model.Context.cs
                //product object add to the table in memory.
                db.SaveChanges();
                //store in sql database
                //only this 3 line require to add object to database

                return product.Name + " was succesfully inserted";
                //comfirmation message that added. it will show the name.(book name)
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public string InsertOrder(order product)
        {
            //we workin on table in sql call BookTB
            //(BookTB product) product object
            try
            {
                //BookTB in model.tt>model.cs (booktb get{ })
                BookDBEntities1 db = new BookDBEntities1();
                //check web confiq to see ur entity name u created tru ado.net entity
                db.orders.Add(product);
                //BookTBs in Model.Context.tt >Model.Context.cs
                //product object add to the table in memory.
                db.SaveChanges();
                //store in sql database
                //only this 3 line require to add object to database

                return product.product + " was succesfully inserted";
                //comfirmation message that added. it will show the name.(book name)
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }





        public string UpdateProduct(int id, BookTB product)// BookTB product (product all the column in BookTB)
        {
            //work different from inserted first we need to fetch the object that need to be updated
            //then repace that by a new object.

          //updatProduct method with two input paramter(id-unique indentifier of the object that need to be updated),
            // and (BookTb product(object that will contain new update data))
            try
            {
                BookDBEntities1 db = new BookDBEntities1();
                //this always goes inside method
                
                BookTB p = db.BookTBs.Find(id);
                //first create a new object BookTB p, then call ur db object/entity object then d.BookTBs table object in (Model.Context.tt >Model.Context.cs) then d.BookTBs.Find-select find method,
                //the find method return object using the Primary key of row.so for input type in (id)
                // get object from database use above syntax(id-unique item to be updated)

                //below, now we will need to replace data store in Book p(object) with the new data input in BookTB product)see above.
                p.Name = product.Name; //product from above  (int id, BookTB product)
                p.Price = product.Price;
                p.TypeID = product.TypeID;
                p.Description = product.Description;
                p.Image = product.Image;
                p.author = product.author;
                //make sure to get all parameter in BookTB(book table). only parameter that in sql table..leave the product key
                //note not to add, dese 2 parameter because this are linked value which we cannot update from here. public virtual BookType BookType { get; set; }  public virtual ICollection<Cart> Carts { get; set; }
   
             
                db.SaveChanges();
                //everything get stored
                //db from  BookDBEntities1 db = new BookDBEntities1();
                return product.Name + " was succesfully updated";
                //return book name and success message

            }
            catch (Exception e)
            {
                return "Error:" + e;
                //else not successful show above message.. database error
            }
        }


        


        public string DeleteProduct(int id)
        {

            // to delete a book row, we goin to use prinary key-id
            try
            {
                BookDBEntities1 db = new BookDBEntities1(); 
                //as always
                BookTB product = db.BookTBs.Find(id);
                //above, first we need to find the value of primary id of a row that need to be deleted.
                // create a new Book object(BookTB product) = the BookDBEntities1 db object,called find and the unique id

                db.BookTBs.Attach(product);

                //then call this method db -BookDBEntities1 db, BookTBs (Model.Context.tt >Model.Context.cs), call Attach(product- from BookTB product);
                db.BookTBs.Remove(product);
                //then remove the attched
                db.SaveChanges();
                //and save changes

                return product.Name + " was succesfully deleted";
                //confirmation message
            }
            catch (Exception e)
            {
                return "Error:" + e;

                //database erroe,if not deleted
            }
        }

        //method return BookTB object call GetProduct with primary key parameter
        public BookTB GetProduct(int id)
        {
            try
            {
                using (BookDBEntities1 db = new BookDBEntities1())
                //create a unsing statement inside BookDBEntities1 object (db), check web confiq to see ur entity name u created tru ado.entity
                {
                    BookTB product = db.BookTBs.Find(id);
                    // crate BookTb object call product = then retrieve it from database BookDBEntities1 object (db).find and id parameter for input.
                   
                    return product;
                    //then return the product correspond to da id input
                }
            }
            catch (Exception)
            {
                return null;
                //wheneva we receive null value we know sumtin went wrong. e.g unknown id
            }
        }

        //A method that return a list/rows of BookTB/book table. with no parameter, call it GetAllProducts()

        public List<BookTB> GetAllProducts()
        {
            //for this method we are goin to be using link language. link or lauguage indicator query is a component of .net famework,
            //that add native data query abilities to.net language
            //it allow us to WRITE SQL LIKE script in object oriented/code manner
            try
            {
                using (BookDBEntities1 db = new BookDBEntities1())
                {
                    List<BookTB> products = (from x in db.BookTBs
                                           select x).ToList();
                    //from x means- slect x(rows) from BookTBs/table..(can call it anything but we call it x) then
                    //it convert the rows to a list so we can use it in our code. with dis code. select x).ToList();

                    //put link translate sql codes to make more object friendly format

                    //object call it products
                    //all rows from table (BooKTB)
                    //
                    return products;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        // A method that return a list/rows of BookTB/book table that reuturn BookTB  have same select types with 1 parameter, call it GetProductsByType(int typeId for input, keyboard the type u want)
        public List<BookTB> GetProductsByType(int typeId)
        {
            try
            {
                using (BookDBEntities1 db = new BookDBEntities1())
                {
                  
                    List<BookTB> products = (from x in db.BookTBs
                                             where x.TypeID == typeId
                                             //where clause x.TypeID(x is what u name it TypeID is a column in BookTB table in sql2012) == typeId (the keyboard u type in)
                                             select x).ToList();
                    //it convert the rows to a list so we can use it in our code. with dis code. select x).ToList();
                    return products;
                    //return the object  List<BookTB>  name. it is important unless u will hv error.
                }
            }
            catch (Exception)
            {
                return null;
            }
        }


        public List<Cart> GetProductsByBollean()
        {
            try
            {
                using (BookDBEntities1 db = new BookDBEntities1())
                {

                    List<Cart> products = (from x in db.Carts
                                            where x.IsInCart == false
                                             //where clause x.TypeID(x is what u name it TypeID is a column in BookTB table in sql2012) == typeId (the keyboard u type in)
                                             select x).ToList();
                    //it convert the rows to a list so we can use it in our code. with dis code. select x).ToList();
                    return products;
                    //return the object  List<BookTB>  name. it is important unless u will hv error.
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }




}