using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Entities.Data_Model
{
    public class Appointments
    {
        [Key]
        public int Appointments_Id { get; set; }
        public string? Description { get; set; }
        public DateTime? AppointmentDateTime { get; set;}

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public enum Days 
        { 
           Saturday,
           Sunday,
           Monday,
           Tuesday,
           Wednesday,
           Thursday,
           Friday
        }
    }
}