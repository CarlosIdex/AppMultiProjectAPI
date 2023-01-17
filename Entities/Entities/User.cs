using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("USER") ]
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
