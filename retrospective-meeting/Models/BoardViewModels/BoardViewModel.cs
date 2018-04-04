using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace retrospective_meeting.Models.BoardViewModels
{
    public class BoardViewModel
    {
        [Required]
        public List<PostItViewModel> WhatWeDidWellSection { get; set; }

        [Required]
        public List<PostItViewModel> WhatCanWeDoBetterSection { get; set; }

        [Required]
        public List<PostItViewModel> WhatPuzzledUsSection { get; set; }

        [Required]
        public List<PostItViewModel> WhatCanWeTryNextSection { get; set; }

        public BoardViewModel()
        {
            WhatWeDidWellSection = new List<PostItViewModel>();
            WhatCanWeDoBetterSection = new List<PostItViewModel>();
            WhatPuzzledUsSection = new List<PostItViewModel>();
            WhatCanWeTryNextSection = new List<PostItViewModel>();
        }
    }
}
