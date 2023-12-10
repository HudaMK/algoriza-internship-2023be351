using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Data_Model
{
    public class Doctor : User
    {
        public string Speciality { get; set; }
        public string? ImagePath { get; set; }
        public List<Appointments> Appointments {get;}
    }
}
