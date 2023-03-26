using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_az_Task.Models
{
    internal class Worker
    {
        public int Id { get; set; }
        public static int StaticId = 1;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }

        public Worker()
        {
            Id = StaticId++;
        }

        public Worker(string? name, string? surname, string? password, string? phone, string? address, int age, DateTime birthday)
        {
            Id = StaticId++;
            Name = name;
            Surname = surname;
            Password = password;
            Phone = phone;
            Address = address;
            Age = age;
            Birthday = birthday;
        }

    }
}
