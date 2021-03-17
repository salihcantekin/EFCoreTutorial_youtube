using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.Data.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public bool IsActive { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
