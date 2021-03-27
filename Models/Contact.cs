using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InteractiveContaclListServer.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Vk { get; set; }
        public string LinkedIn { get; set; }
        public string Twitter { get; set; }


        public string FaceBookData
        {
            get
            {
                return "Данные социальной сети " + this.Facebook;

            }
        }

    }
}
