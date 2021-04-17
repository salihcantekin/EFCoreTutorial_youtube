using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.WebApi
{
    public class StudentFilter
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public int? Number { get; set; }
    }
}
