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
        public  AddressBookManagement()
        {
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("City", typeof(string));
            dataTable.Columns.Add("State", typeof(string));
            dataTable.Columns.Add("Zip", typeof(double));
            dataTable.Columns.Add("PhoneNumber", typeof(double));
            dataTable.Columns.Add("Email", typeof(string));

            // Creating rows and adding data into row
            dataTable.Rows.Add("Vaibhav", "Bohari", "Agar", "Akola", "Maharashtra", 444006, 9730913415, "vaibhav@gmail.com");
            dataTable.Rows.Add("sumit", "Patel", "GandhiNagar", "Amravati", "Goa", 509000, 9785474102, "Sumit@gmail.com");
            dataTable.Rows.Add("Shubham", "Kulkarni", "Mumbai", "RamNagar", "Maharashtra", 409211, 8415789858, "shubham@gmail.com");
            dataTable.Rows.Add("Rohit", "Fuse", "janmod", "Buldhana", "mp", 489201, 9458257321, "Rohit@gmail.com");
            dataTable.Rows.Add("Gopal", "Wagh", "Api", "Pune", "Maharashtra", 478952, 841789456, "Gopal@gmail.com");
            dataTable.Rows.Add("Vinavak", "Kute", "GandhiRoad", "Hadapser", "mp", 489206, 7894567112, "vinavak@gmail.com");
        }

       
        public void getAllData()
        {
            foreach (var data in dataTable.AsEnumerable())
            {
                Console.WriteLine("FirstName: " + data.Field<string>("Firstname") + ","
                    + "LastName: " + data.Field<string>("LastName") + ","
                    + "Address: " + data.Field<string>("Address") + ","
                    + "City: " + data.Field<string>("City") + ","
                    + "State: " + data.Field<string>("State") + ","
                    + "Zip: " + data.Field<double>("Zip") + ","
                    + "PhoneNumber: " + data.Field<double>("PhoneNumber") + ","
                    + "Email: " + data.Field<string>("Email"));
                Console.WriteLine("\n");
            }
        }
        public void UpdatePersonByName()
        {
            Console.WriteLine("Enter FirstName : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter columnName : ");
            string columnName = Console.ReadLine();
            Console.WriteLine("Enter Upadated Value : ");
            string Updatedvalue = Console.ReadLine();
            DataRow updatedperson = dataTable.Select("FirstName = '" + firstName + "'").FirstOrDefault();
            updatedperson[columnName] = Updatedvalue;
            Console.WriteLine("Contanted is Updated ");
            getAllData();
        }
        public void DeletePersonByName()
        {
            Console.WriteLine("Enter Firstname: ");
            string firstName = Console.ReadLine();
            var data = dataTable.AsEnumerable().Where(x => x.Field<string>("FirstName") == firstName);

            foreach (var rows in data.ToList())
            {
                rows.Delete();
            }
            getAllData();
        }
    }
}
    

    



