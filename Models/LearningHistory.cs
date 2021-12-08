using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class LearningHistory
    {
        public string UserId { get; init; }

        public int CourseId { get; init; }

        [Required(ErrorMessage = "学习进度不得为空")]
        public int Progress { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
