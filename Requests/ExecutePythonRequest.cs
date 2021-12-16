using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Requests
{
    public class ExecutePythonRequest
    {
        [Required]
        public string ConnectId { get; set; }

        [Required]
        public string Code { get; set; }
    }
}