using System;
namespace OOPS
{
    public class Contact
    {
        public string Name { get; }    
        public string Address { get; private set; } 
        public Contact(String contactName , String contactAddress)
        {
            Name = contactName;
            Address = contactAddress;
        }   
    }
}