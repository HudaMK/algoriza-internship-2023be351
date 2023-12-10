using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Data_Model
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }
        public string Description { get; set; }
        public int Patient_Id { get; set; }
        public User Patient_User { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public bool isConfirmed {  get; set; }
        public bool DiscountAdded {  get; set; }


        public enum DiscountType { Percentage, Value}
    }
}
