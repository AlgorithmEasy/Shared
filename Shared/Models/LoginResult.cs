using System;

namespace AlgorithmEasy.Shared.Models
{
    public class LoginResult
    {
        /// <summary>
        ///     用户是否登陆成功.
        /// </summary>
        public bool IsAuthenticated { get; init; }

        /// <summary>
        ///     登录用户 ID.
        /// </summary>
        public string UserId { get; init; }

        /// <summary>
        ///     此次登录的 sessionId.
        /// </summary>
        public Guid SessionId { get; init; }
    }
}