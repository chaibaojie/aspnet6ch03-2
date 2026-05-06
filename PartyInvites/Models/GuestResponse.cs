using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="请输入姓名")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="请输入Email地址")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="请输入电话号码")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="请选择是否参加")]
        public bool? WillAttend { get; set; }
    }
}
