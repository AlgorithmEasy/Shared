using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Models
{
    public class Role
    {
        public int RoleId { get; init; }

        [Required]
        [MaxLength(30, ErrorMessage = "角色名不得超过30字")]
        public string RoleName { get; set; }
    }
}
