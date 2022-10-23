using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class QuestionDetailDto:IDto
    {
        public int QuestionId { get; set; }
        public int? QuestionTypeId { get; set; }
        public int? QuestionCategoryId { get; set; }
        public string QuestionName { get; set; }

        public string QuestionTypeName { get; set; }//bu veriyi göndermeye gerek yok

        public string QuestionCategoryName { get; set; }
    }
}
