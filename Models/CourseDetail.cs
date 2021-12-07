using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class CourseDetail
    {
        [Required(ErrorMessage = "课程名称不得为空")]
        [MaxLength(30, ErrorMessage = "课程名称不得超过30字")]
        public string Title { get; set; }

        public string Content { get; set; }

        public string Workspace { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}