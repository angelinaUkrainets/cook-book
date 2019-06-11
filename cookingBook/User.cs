using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace cookingBook
{
    public class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Login { get; set; }
        public string Email { get; set; }

        public string Number { get; set; }

        public bool IsMale { get; set; }

        public string Password { get; set; }
    }
}
