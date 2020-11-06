using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LiveCode
{
    /*
0	        1	       2	      3 	        4           	5       	6	        7               	8       	9
productID productName supplierID categoryID  quantityPerUnit unitPrice   unitsInStock unitsOnOrder    reorderLevel discontinued
0	            1	       2     3	        4	            5	         6  	7	    8	  9 	    10  	11	    12  	13      	14  	15  	16  	17
employeeID lastName    firstName title   titleOfCourtesy birthDate   hireDate address city region  postalCode country homePhone extension   photo notes   reportsTo photoPath

    */
    public class Products // productID,productName,supplierID,categoryID,quantityPerUnit,unitPrice,unitsInStock,unitsOnOrder,reorderLevel,discontinued
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal  UnitPrice { get; set; }
        //etc
    }

    public class Employee //employeeID,lastName,firstName,title,titleOfCourtesy,birthDate,hireDate,address,city,region,postalCode,country,homePhone,extension,photo,notes,reportsTo,photoPath
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Title { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; internal set; }
    }

    public class Demo
    {

        const string EmployeesUrl = "https://raw.githubusercontent.com/graphql-compose/graphql-compose-examples/master/examples/northwind/data/csv/employees.csv";
        const string ProductsUrl = "https://raw.githubusercontent.com/graphql-compose/graphql-compose-examples/master/examples/northwind/data/csv/products.csv";

        #region UrlReading
        public IEnumerable<string> DownloadAsLines(Uri url)
        {
            WebClient wc = new WebClient();
            return BytesToLines(wc.DownloadData(url));                        
        }
        private IEnumerable<string> BytesToLines(byte[] bytes)
        {
            var result = new List<string>();
            using (StreamReader sr = new StreamReader(new MemoryStream(), Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    result.Add(line);
            }
            return result;
        }
        #endregion

        public IEnumerable<string> ReadLinesFromFile(string f)
        {
            return File.ReadAllLines(f);
        }

        //public IEnumerable<Employee> Employees => ReadLinesFromFile("employees.csv")

        Employee arrayToEmployee(string[] sa) => new Employee() { Id = int.Parse(sa[0]), City = sa[8], Firstname = sa[2], Lastname = sa[1], PostalCode = sa[10], Title = sa[3], Country = sa[11] };

        public void Run()
        {
            
        }
    }
}