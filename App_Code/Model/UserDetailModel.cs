using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserDetailModel
/// </summary>
namespace Models
{
    public class UserDetailModel
    {
        public UserDetail GetUserInformation(string guId)
        {
            BookDBEntities1 db = new BookDBEntities1();
            var info = (from x in db.UserDetails
                        where x.Guid == guId
                        select x).FirstOrDefault();
            return info;
        }

        public void InsertUserDetail(UserDetail userDetail)
        {
            BookDBEntities1 db = new BookDBEntities1();
            db.UserDetails.Add(userDetail);
            db.SaveChanges();
        }
    }
}