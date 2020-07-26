using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL.DBOperations.TmpModels;
using System.Diagnostics;

namespace BLL.DBOperations
{
    public class Person
    {
        public static tbl_Person loggedinuser { get; set; } 
        public static dynamic login(string username, string password)
        {
            RMSDBEntities db = DBContext.getInstance();
            tbl_Person user = db.tbl_Person.Where(a => (a.UserName == username && a.Password == password)).FirstOrDefault();
            Person.loggedinuser = user;
            return user;
        }
        public static void insert(tbl_Person user)
        {
            RMSDBEntities db = DBContext.getInstance();
            db.tbl_Person.Add(user);
            db.SaveChanges();
        }
    }
}
