using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G3.dal.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "name is required!")]

        public string Name { get; set; }
        [Required (ErrorMessage ="code is required!")]
        public string Code { get; set; }
        [DisplayName("Date Of Creation")]
        public DateTime DateOfCreation { get; set; }
    }
}
