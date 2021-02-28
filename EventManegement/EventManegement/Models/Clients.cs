using System;
using System.Data.Entity;

namespace EventManegement.Models
   
{
    public class Clients
    {
        public int C_Id { get; set; }
        public string C_Add { get; set; }
        public string C_Email { get; set; }
        public string C_Phone { get; set; }
        public string C_Pass { get; set; }
        public string C_Username { get; set; }
        public string C_Name { get; set; }

    }
    public class ClientsDBContext : Clients
    {
        public  Dbset<Clients> Client {get; set;}
    }
}
   