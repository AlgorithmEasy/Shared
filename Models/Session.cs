using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace AlgorithmEasy.Shared.Models
{
    public class Session
    {
        public Guid SessionId { get; init; }

        [Required(ErrorMessage = "用户不得为空。")]
        public User User { get; set; }

        public DateTime LoginTime { get; init; }

        public IPAddress Ip { get; set; }
    }
}
