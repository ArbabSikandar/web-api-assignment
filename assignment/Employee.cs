namespace WebAPICURD_Demo.Models  
{  
    using System;  
    using System.Collections.Generic;  
      
    public partial class Employee  
    {  
        public int Employee_Id { get; set; }  
        public string First_Name { get; set; }  
        public string Last_Name { get; set; }  
        public Nullable<decimal> Salary { get; set; }  
        public string Joing_Date { get; set; }  
        public string Department { get; set; }  
    }  
}  