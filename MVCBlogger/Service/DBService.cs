using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBlogger.Models;

namespace MVCBlogger.Service
{
    public class DBService
    {
        public Models.DatabaseEntities db = new Models.DatabaseEntities();

        //return items
        public List<Table> GetData()
        {
            return (db.Table.ToList());
        }
        //save usre input into table
        public void DBCreate(string strTitle, string strContent)
        {
            //new table object
            Table newData = new Table();

            //save properties to object
            newData.Title = strTitle;
            newData.Content = strContent;
            newData.Time = DateTime.Now;

            //add data object to table
            db.Table.Add(newData);
            //save to db
            db.SaveChanges();

        }
        internal bool Delete(int? articleId)
        {
            var found = db.Table.SingleOrDefault(a => a.Id == articleId);
            if (found != null)
            {
                db.Table.Remove(found);
                db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}