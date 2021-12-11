using System.Collections.Generic;
using AlgorithmEasy.Shared.Models;

namespace AlgorithmEasy.Shared.Responses
{
    public class GetCoursesResponse
    {
        public IEnumerable<Course> Courses { get; init; }
    }
}