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

        private string _email;
        [Required, StringLength(50), EmailAddress]
        public string Email {
            get { return _email; }
            set
            {
                if (_email == value) return;
                _email = value;
            }
        }

        public string Number { get; set; }

        public bool IsMale { get; set; }

        public string Password { get; set; }
    }
}
