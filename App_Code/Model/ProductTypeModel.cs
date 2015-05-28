using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductTypeModel
/// </summary>
public class ProductTypeModel
{   //second model done
    public string InsertProductType( BookType productType)
    {
        //working on
        //Table in sql. BookType

        //copy and paste code from BookTB that you done first.
        //ctrl + h, replace BookTB with BookType,
        //replace product with productType,see above.
        try
        {
            BookDBEntities1 db = new BookDBEntities1();
            db.BookTypes.Add(productType);
            db.SaveChanges();

            return productType.Name + "was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProductType(int id,  BookType productType)
    {
        try
        {
            BookDBEntities1 db = new BookDBEntities1();

            
             BookType p = db.BookTypes.Find(id);

            p.Name = productType.Name;
            //dont put the primary key is it identity,generate automatically by sql
            //check for error after replace,,FIX THI ERRORS
            db.SaveChanges();
            return productType.Name + "was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProductType(int id)
    {
        try
        {
            BookDBEntities1 db = new BookDBEntities1();
             BookType productType = db.BookTypes.Find(id);

            db.BookTypes.Attach(productType);
            db.BookTypes.Remove(productType);
            db.SaveChanges();

            return productType.Name + "was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}