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

        public string FacebookData
        {
            get
            {
                return "Данные социальной сети Facebook " + this.Facebook;
            }
        }

        public string InstagramData
        {
            get
            {
                return "Данные социальной сети Instagram " + this.Instagram;

            }
        }

        public string VkData
        {
            get
            {
                return "Данные социальной сети Vk " + this.Vk;

            }
        }

        public string LinkedInData
        {
            get
            {
                return "Данные социальной сети LinkedIn " + this.LinkedIn;

            }
        }

        public string TwitterData
        {
            get
            {
                return "Данные социальной сети Twitter " + this.Twitter;

            }
        }

    }
}
