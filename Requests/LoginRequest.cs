using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Requests
{
    public class LoginRequest
    {
        /// <summary>
        ///     登录用户 ID.
        /// </summary>
        [Required(ErrorMessage = "请输入用户名。")]
        public string UserId { get; set; }

        /// <summary>
        ///     登录用户密码, 应进行一次 Sha256 加密.
        /// </summary>
        [Required(ErrorMessage = "请输入密码。")]
        public string Password { get; set; }
    }
}