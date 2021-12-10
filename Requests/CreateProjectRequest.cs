using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Requests
{
    public class CreateProjectRequest
    {
        [Required]
        public string ProjectName { get; init; }
    }
}