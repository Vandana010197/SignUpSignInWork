using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class VerifyAccount
    {
        [Key]
        public int Id { set; get; }
        public string Email { get; set; }
        public string OTP { get; internal set; }
        public DateTime SendTime { get; set; }

    }
}
