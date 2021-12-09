using System.Collections.Generic;
using AlgorithmEasy.Shared.Models;

namespace AlgorithmEasy.Shared.Responses
{
    public class GetPersonalProjectsResponse
    {
        public IEnumerable<Project> Projects { get; init; }
    }
}