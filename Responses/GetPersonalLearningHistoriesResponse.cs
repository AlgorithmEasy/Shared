using System.Collections.Generic;
using AlgorithmEasy.Shared.Models;

namespace AlgorithmEasy.Shared.Responses
{
    public class GetPersonalLearningHistoriesResponse
    {
        public IEnumerable<LearningHistory> LearningHistories { get; set; }
    }
}