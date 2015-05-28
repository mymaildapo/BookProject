using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    //third model done
    public string InsertCart(Cart cart)
    {
        //Cart Table in sql

        //copy and paste code from BookTB that you done first.
        //ctrl + h, replace BookTB with Cart,
        //replace product with cart,see above.
        try
        {
            BookDBEntities1 db = new BookDBEntities1();
            db.Carts.Add(cart);
            db.SaveChanges();

            return cart.DatePurchased + "Order was succesfully inserted";
            //fix this error and return date was purchased

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string InsertOrder(order Order)
    {
        //Cart Table in sql

        //copy and paste code from BookTB that you done first.
        //ctrl + h, replace BookTB with Cart,
        //replace product with cart,see above.
        try
        {
            BookDBEntities1 db = new BookDBEntities1();
            db.orders.Add(Order);
            db.SaveChanges();

            return Order.date + "Order was succesfully inserted";
            //fix this error and return date was purchased

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

   

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            BookDBEntities1 db = new BookDBEntities1();

            //Fetch object from db
            Cart p = db.Carts.Find(id);

            p.DatePurchased = cart.DatePurchased;
            p.ClientID = cart.ClientID;
            p.Amount = cart.Amount;
            p.IsInCart = cart.IsInCart;
            p.ProductID = cart.ProductID;
            //dont put the primary key is it identity,generate automatically by sql
            //check for error after replace, FIX THI ERRORS, check sql for column name best way to only put everythin in table EXCEPT primary key
            return cart.DatePurchased + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    //public string UpdateOrder(int id, order ordr)
    //{
    //    try
    //    {
    //        BookDBEntities1 db = new BookDBEntities1();

    //        //Fetch object from db
    //        order p = db.orders .Find(id);
    //        p.date = ordr.date;
    //        p.client = ordr.client;
    //        p.amount = ordr.amount;
    //        p.price = ordr.price;
    //        p.orderShipped = ordr.orderShipped;
    //        p.id = ordr.id;

    //        db.SaveChanges();
    //        return ordr.date + " was succesfully updated";

    //    }
    //    catch (Exception e)
    //    {
    //        return "Error:" + e;
    //    }
    //}


    public string DeleteCart(int id)
    {
        try
        {
            BookDBEntities1 db = new BookDBEntities1();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DatePurchased + "was succesfully deleted";
            //FIX THI ERROR
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    //return a List of cart object with string clientId parameter for input 
    public List<Cart> GetOrdersInCart(string clientId)
    {
        //this method will return all items within the user current shopping cart/carts table
        BookDBEntities1 db = new BookDBEntities1();
        List<Cart> orders = (from x in db.Carts //list object containing cart object called order
                             where x.ClientID == clientId // we need to get items of the current user
                             && x.IsInCart //and the object must not be paid for ye timply IsInCart is set to true
                             orderby x.DatePurchased descending //will order the object by the date it was purchased.
                             select x).ToList(); //then we will return this result as a list by calling ToList()  mtthod.  
        
        return orders; // and return the orders object.
    }

    //return int value with string clientId parameter
    public int GetAmountOfOrders(string clientId)
    {
        //this method will retrieve total number of amount/quatity of items in the cart table
        //for eg if the user have order two ebook and 1 magazine we want this methid to return the number 3
        try
        {
            BookDBEntities1 db = new BookDBEntities1();// connect to the databas
            int amount = (from x in db.Carts
                          where x.ClientID == clientId
                          && x.IsInCart
                          select x.Amount).Sum(); //will return the sum of the amount field/column. Amount is a column in Carts table

            return amount; // return the amount object
        }
        catch
        {
            return 0;
        }
    }
    //void method no return using int id/unique key, and int quantity for input
    public void UpdateQuantity(int id, int quantity)
    {
        //this method will update the update of the selected int id/unique product in the shopping cart
        BookDBEntities1 db = new BookDBEntities1();
        Cart p = db.Carts.Find(id); //create  cart object called p and fill it with database data by typin in db.Carts with id parameter for input
        p.Amount = quantity; // and then set the amount the cart object p.Amount- Amount is name of the column in carrt table to new quantity input..see above UpdateQuantity(int id, int quantity)

        db.SaveChanges(); // to save ur changes to the database.
    }

    //void method which have a List of cart object as input,List<Cart>,called carts, can be call anythin
    public void MarkOrdersAsPaid(List<Cart> carts)
    {

        //this method will mark all the item in the shopping cart as paid as soon as the user as complete their transaction/ avoid putin the Credit card payment
        BookDBEntities1 db = new BookDBEntities1();

        // A user has paid so we now to mark all the object in the cart as paid for.
        if (carts != null) //check to see if the input is not null
        {
            foreach (Cart cart in carts)// for each cart within our input list MarkOrdersAsPaid(List<Cart> carts)
            {
                Cart oldCart = db.Carts.Find(cart.ID);//
                oldCart.DatePurchased = DateTime.Now;
                oldCart.IsInCart = false;
            }
            db.SaveChanges();
        }
    }
}