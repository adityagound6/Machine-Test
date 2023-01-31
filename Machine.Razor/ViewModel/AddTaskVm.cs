using Context.Razor.Context;
using System.ComponentModel.DataAnnotations;

namespace Machine.Razor.ViewModel
{
    public class AddTaskVm
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        public string TaskDesc { get; set; }
        [Required]
        public DateTime TaskExpiryDate { get; set; }
        public bool Important { get; set; }
        public List<UserModel> Users { get; set; } = new List<UserModel>();
    }
}
