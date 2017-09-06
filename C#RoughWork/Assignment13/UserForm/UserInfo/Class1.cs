using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfo
{
    public class User
    {
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
