using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace retrospective_meeting.Models.BoardViewModels
{
    public class PostItViewModel
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
