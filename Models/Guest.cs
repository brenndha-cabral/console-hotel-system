using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace console_hotel_system.Models
{
    public class Guest
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdDocument { get; set; }

        public Guest(
            string id,
            string fullName,
            int age,
            string birthday,
            string gender,
            string address,
            string phone,
            string email,
            string idDocument
            )
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Birthday = birthday;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            IdDocument = idDocument;
        }
    }
}