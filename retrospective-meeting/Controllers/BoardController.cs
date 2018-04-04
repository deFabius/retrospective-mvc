using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using retrospective_meeting.Models.BoardViewModels;

namespace retrospective_meeting.Controllers
{
    [Route("[controller]/[action]")]
    public class BoardController : Controller
    {
        [HttpGet]
        public IActionResult Display()
        {
            var PostIt = new PostItViewModel() {
                Id = "aoisnaoisnfa",
                Content = "Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Sed porttitor lectus nibh."
            };

            BoardViewModel Board = new BoardViewModel();
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);
            Board.WhatWeDidWellSection.Add(PostIt);

            Board.WhatCanWeDoBetterSection.Add(PostIt);
            Board.WhatCanWeDoBetterSection.Add(PostIt);
            Board.WhatCanWeDoBetterSection.Add(PostIt);
            Board.WhatCanWeDoBetterSection.Add(PostIt);
            Board.WhatCanWeDoBetterSection.Add(PostIt);
            Board.WhatCanWeDoBetterSection.Add(PostIt);
            Board.WhatCanWeDoBetterSection.Add(PostIt);

            Board.WhatCanWeTryNextSection.Add(PostIt);
            Board.WhatCanWeTryNextSection.Add(PostIt);
            Board.WhatCanWeTryNextSection.Add(PostIt);
            Board.WhatCanWeTryNextSection.Add(PostIt);

            return View(Board);
        }
    }
}