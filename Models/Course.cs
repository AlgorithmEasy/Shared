
using System.Collections.Generic;

namespace AlgorithmEasy.Shared.Models
{
    public class Course
    {
        public int CourseId { get; init; }

        public IEnumerable<LearningHistory> LearningHistories { get; init; }
        
        public CourseDetail CourseDetail { get; init; }
    }
}