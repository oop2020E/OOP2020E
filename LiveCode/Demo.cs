using System;
using System.Collections;
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

    //class InfNumbers : IEnumerable<int>
    //{
    //    public IEnumerator<int> GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}


    public class Employee //employeeID,lastName,firstName,title,titleOfCourtesy,birthDate,hireDate,address,city,region,postalCode,country,homePhone,extension,photo,notes,reportsTo,photoPath
    {
        public override string ToString()
        {
            return Id + " " +Firstname + " " + Lastname;
        }
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

        IEnumerable<long> GetInfSequence()
        {
            long l = 0;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
            yield return l++;
        }


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

        public IEnumerable<Employee> Employees {
            get {
                
                return ReadLinesFromFile("employees.csv").Skip(1)
                    .Where(v => { Console.WriteLine("kaldt"); return true; })
                    .Select(s => s.Split(','))
                    .Select(sa => arrayToEmployee(sa))
                    ;
            }
        }

        Employee arrayToEmployee(string[] sa) => new Employee() { 
            Id = int.Parse(sa[0]), 
            City = sa[8], 
            Firstname = sa[2], 
            Lastname = sa[1],
            PostalCode = sa[10], 
            Title = sa[3], 
            Country = sa[11] 
        };

        public void Run()
        {
            var intlist = new List<int>() { 2, 4, 6 };


            foreach (var item in GetInfSequence().Concat(GetInfSequence()))
            {
                Console.WriteLine(item);

            }

            List<Employee> amerikanere = Employees.Take(2).ToList();
            //.Join(intlist,  e => e.Id, i => i, (e, i) => new { 
            //    Fullname=$"{e.Firstname} {e.Lastname}", 
            //    Id=i }); 
            //.Where(v => v.Country != "USA")
            //.GroupBy(v => v.Country)

            //.SelectMany(g => g);


            //Console.WriteLine(v);
            Console.WriteLine("første iteration");
            foreach (var item in amerikanere)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Anden iteration");
            foreach (var item in amerikanere)
            {
                Console.WriteLine(item);
            }

        }
    }
}