using System;
using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Data
{
    public class Course
    {
        public int CourseId { get; init; }

        [MaxLength(30, ErrorMessage = "课程名称不得超过30字")]
        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}