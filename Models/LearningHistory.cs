using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class LearningHistory
    {
        public Course Course { get; init; }

        [Required(ErrorMessage = "学习进度不得为空")]
        public int Progress { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
