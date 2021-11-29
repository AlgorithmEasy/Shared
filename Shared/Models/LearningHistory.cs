using System;

namespace AlgorithmEasy.Shared.Models
{
    public class LearningHistory
    {
        public Course Course { get; init; }

        public int Progress { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
