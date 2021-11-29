namespace AlgorithmEasy.Shared.Request
{
    public class LoginRequest
    {
        /// <summary>
        ///     登录用户 ID.
        /// </summary>
        public string UserId { get; init; }

        /// <summary>
        ///     登录用户密码, 应进行一次 Sha256 加密.
        /// </summary>
        public byte[] Password { get; init; }
    }
}