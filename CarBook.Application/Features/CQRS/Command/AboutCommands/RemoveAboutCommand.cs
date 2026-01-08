using System;
using System.Collections.Generic;
using System.Text;

namespace CarBook.Application.Features.CQRS.Command.AboutCommands
{
    public class RemoveAboutCommand
    {
        public int Id { get; set; }
        public RemoveAboutCommand(int id)
        {
            Id = id;    
        }
    }
}
