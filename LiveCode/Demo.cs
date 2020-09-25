using System;
using System.Collections.Generic;
using System.IO;

namespace LiveCode
{

    class PersonException : Exception
    {
        protected PersonException(string message)
        {
            

        }
    }
    class NameFormatException : PersonException
    {
        public NameFormatException(string message) : base(message)
        {
            
        }

        
    }

    public class Demo 
    {
        // TODO opgaver fra sidst

        //EXAMPLE 10 throw existing exceptions -- ArgumentException and derivatives, nameof etc
        //EXAMPLE 20 throw custom exceptions -- NameMustStartWithCapitalLetterException
        //EXAMPLE 30 catching exceptions, all, specific, rethrow
        //EXAMPLE

        


        public void Run()
        {
            try
            {
                DiskDb db = new DiskDb();
                PersonCatalog pc = new PersonCatalog(db);

                pc.Add(new Person());

            }
            catch (Exception e)
            {

            }

        }
    }
}