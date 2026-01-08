using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Command.AboutCommands
{
    public class CreateAboutCommand
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
