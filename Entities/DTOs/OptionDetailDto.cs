using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OptionDetailDto:IDto
    {
        public int QuestionId { get; set; }

        public string QuestionName { get; set; }
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public bool IsTrue { get; set; }

        


    }
}
