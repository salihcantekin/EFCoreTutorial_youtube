using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.Data.Models
{
    public class StudentAddress
    {
        public int Id { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string FullAddress { get; set; }

        public string Country { get; set; }

        public virtual Student Student { get; set; }
    }
}
