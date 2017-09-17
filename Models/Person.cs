using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Models
{
    public class Person
    {
        private static List<Person> _Data = new List<Person>();

        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(4)]
        public string FirstName { get; set; }

        [MaxLength(60)]
        public string LastName { get; set; }

        public void Add() {
            ID = _Data.Count() + 1;
            _Data.Add(this);
        }

        public bool Update() {
            var data = _Data.SingleOrDefault(p => p.ID == ID);
            if (data == null) return false;
            data.FirstName = FirstName;
            data.LastName = LastName;
            return true;
        }

        public bool Get() {
            var data = _Data.SingleOrDefault(p => p.ID == ID);
            if (data == null) return false;
            FirstName = data.FirstName;
            LastName = data.LastName;
            return true;
        }

        public bool Delete() {
            var data = _Data.SingleOrDefault(p => p.ID == ID);
            if (data == null) return false;
            _Data.Remove(data);
            return true;
        }

        public static List<Person> GetAll()
        {
            return _Data;
        }

    }
}
