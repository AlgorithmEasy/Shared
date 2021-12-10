using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Requests
{
    public class RenameProjectRequest
    {
        [Required]
        public string OldProjectName { get; init; }

        [Required]
        public string NewProjectName { get; init; }
    }
}