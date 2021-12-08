using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class LearningHistory
    {
        [Required(ErrorMessage = "用户id不得为空。")]
        public string UserId { get; init; }

        [Required(ErrorMessage = "课程id不得为空。")]
        public int CourseId { get; init; }

        [Required(ErrorMessage = "学习进度不得为空。")]
        public int Progress { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
