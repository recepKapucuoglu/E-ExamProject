using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class QuestionExamDto : IDto
    {
        public int ExamID { get; set; }

        public int QuestionID { get; set; }
    
        public string ExamName { get; set; }
        public string QuestionName { get; set; }
        public string QuestionTitle { get; set; }

        public int QuestionTypeId { get; set; }

        public int QuestionCategoryId { get; set; }

    }
}
