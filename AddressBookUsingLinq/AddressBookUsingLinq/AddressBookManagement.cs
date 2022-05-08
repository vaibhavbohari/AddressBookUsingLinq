using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AddressBookUsingLinq
{
    public class AddressBookManagement
    {
        public DataTable dataTable = new DataTable();
        public AddressBookManagement()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(double));
            dataTable.Columns.Add("PhoneNumber", typeof(double));
            dataTable.Columns.Add("Email", typeof(string));
        }
    }
}


