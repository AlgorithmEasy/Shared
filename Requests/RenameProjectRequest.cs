﻿using System.ComponentModel.DataAnnotations;

namespace AlgorithmEasy.Shared.Requests
{
    public class RenameProjectRequest
    {
        [Required]
        public string OldProjectName { get; init; }

        [Required(ErrorMessage = "项目名不得为空。")]
        [MaxLength(30, ErrorMessage = "项目名称不得超过30字。")]
        public string NewProjectName { get; set; }
    }
}