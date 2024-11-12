using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WpfApp4.DB
{
    public partial class Table
    {
        public Table GetByGender(string gender)
        {
            LinqtoSqlDataContext db = new LinqtoSqlDataContext();
            Table tb = (from mydata in db.Tables where mydata.Gender == gender  select mydata).Single(); 
            return tb;
        }
        public static bool Add_data(string fname, string lname, string gender, string country)
        {
            LinqtoSqlDataContext db = new LinqtoSqlDataContext();
            Table tb = new Table();
            tb.Firstname=fname;
            tb.Lastname=lname;
            tb.Gender=gender;
            tb.Country=country;
            db.Tables.InsertOnSubmit(tb);
            db.SubmitChanges();
            MessageBox.Show("done");
            return true;
        }
    }
}
