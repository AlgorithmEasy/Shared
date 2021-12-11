using System.Collections.Generic;
using AlgorithmEasy.Shared.Models;

namespace AlgorithmEasy.Shared.Responses
{
    public class GetStudentLearningHistoriesResponse
    {
        public IEnumerable<User> Users { get; init; }
    }
}