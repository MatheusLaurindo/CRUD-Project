using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrud.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public User()
        {
        }

        public User(int id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
