using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace AlgorithmEasy.Shared.Data
{
    public class Project
    {
        [MaxLength(30, ErrorMessage = "课程名称不得超过30字")]
        public string ProjectName { get; set; }

        public string Workspace { get; set; }
    }
}