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

        public IEnumerable<Employee> Employees => ReadLinesFromFile("employees.csv").Skip(1).Select(s => s.Split(',')).Select(arrayToEmployee);

        Employee arrayToEmployee(string[] sa) => new Employee() { Id = int.Parse(sa[0]), City = sa[8], Firstname = sa[2], Lastname = sa[1], PostalCode = sa[10], Title = sa[3], Country = sa[11] };

        public void Run()
        {
            
        }
    }
}