using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreTutorial.Data.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int Number { get; set; }
    }
}
