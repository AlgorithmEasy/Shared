using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Requests
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "用户名不能为空。")]
        [MaxLength(30, ErrorMessage = "用户名不得超过30个字符。")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "昵称不能为空。")]
        [MaxLength(20, ErrorMessage = "昵称不得超过20个字符。")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "密码不能为空。")]
        public string Password { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required(ErrorMessage = "邮箱不能为空。")]
        [MaxLength(100)]
        [EmailAddress(ErrorMessage = "邮箱地址格式不正确。")]
        public string Email { get; set; }
    }
}