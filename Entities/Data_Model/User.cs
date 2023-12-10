using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Data_Model
{
    public class User
    {
        [Key]
        public string User_Id { get; set; }
        public string First_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public Gender gender { get; set; }

        public enum Gender { female,male}

    }
}
