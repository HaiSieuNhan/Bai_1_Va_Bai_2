using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test_Version.Models
{
    public class Test_VersionViewModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Tên Không Được Để Trống")]
        public string VersionName { get; set; }
    }
}
