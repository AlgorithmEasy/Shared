namespace AlgorithmEasy.Shared.Models
{
    public class RegisterResult
    {
        /// <summary>
        ///     注册是否成功.
        /// </summary>
        public bool IsSuccess { get; init; }

        /// <summary>
        ///     注册用户 ID.
        /// </summary>
        public string UserId { get; init; }
    }
}