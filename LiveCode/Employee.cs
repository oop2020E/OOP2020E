namespace LiveCode
{
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
}