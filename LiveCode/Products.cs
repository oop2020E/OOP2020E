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
}