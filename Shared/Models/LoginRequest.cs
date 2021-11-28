using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class LoginRequest
    {
        /// <summary>
        ///     登录用户 ID.
        /// </summary>
        [Required(ErrorMessage = "用户名不得为空")]
        public string UserId { get; init; }

        /// <summary>
        ///     登录用户密码, 应进行一次 Sha256 加密.
        /// </summary>
        [Required(ErrorMessage = "密码不得为空")]
        public byte[] Password { get; init; }
    }
}