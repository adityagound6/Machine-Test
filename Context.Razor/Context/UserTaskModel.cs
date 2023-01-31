using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Razor.Context
{
    public class UserTaskModel
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? TaskDesc { get; set; }
        public DateTime TaskExpiryDate { get; set; }
        public byte Important { get; set; }
        public byte? IsActive { get; set; }
        public byte? IsDelete { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
