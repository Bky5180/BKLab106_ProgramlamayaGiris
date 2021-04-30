using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burak_CoreEntityCodeFirst.Entity
{
    // Yeni versiyon (Cakma Entity Splitting)
    public class AppUser
    {
        [Key]
        public int UserID { get; set; }
        public AppUserLoginDetails LoginDetails { get; set; }
        public AppUserContactDetails ContactDetails { get; set; }

        public AppUser()
        {

        }

        public AppUser(string username, string password, string contactNumber, string address)
        {
            LoginDetails = new AppUserLoginDetails
            {
                Username = username,
                Password = password
            };

            ContactDetails = new AppUserContactDetails
            {
                ContactNumber = contactNumber,
                Address = address
            };
        }
    }

    public class AppUserContactDetails
    {
        [Key]
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        public AppUser User { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }

    public class AppUserLoginDetails
    {
        [Key]
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }

        public AppUser User { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }

    // Eski versiyon (Entity Splitting icin)
    //public class AppUser
    //{
    //    public int ID { get; set; }
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //    public string ContactNumber { get; set; }
    //    public string Address { get; set; }
    //}
}
