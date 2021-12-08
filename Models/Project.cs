using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class Project
    {
        public string UserId { get; init; }

        [Required(ErrorMessage = "项目名称不得为空。")]
        [MaxLength(30, ErrorMessage = "课程名称不得超过30字。")]
        public string ProjectName { get; set; }

        public string Workspace { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}