using System;

namespace AlgorithmEasy.Shared.Responses
{
    public class LoginResponse
    {
        /// <summary>
        ///     用户是否登陆成功.
        /// </summary>
        public bool IsAuthenticated { get; init; }

        /// <summary>
        ///     登录用户 ID.
        /// </summary>
        public string UserId { get; init; }

        public string Role { get; init; }

        public string Token { get; init; }
    }
}