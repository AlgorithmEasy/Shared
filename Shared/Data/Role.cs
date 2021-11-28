using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Data
{
    public class Role
    {
        public int RoleId { get; init; }

        [Required]
        public string RoleName { get; set; }
    }
}
