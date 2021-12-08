using System;

namespace AlgorithmEasy.Shared.Responses
{
    public class LoginResponse
    {
        public string UserId { get; init; }

        public string Role { get; init; }

        public string Token { get; init; }
    }
}