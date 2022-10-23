using Core.Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class QuestionCategoryDetailDto:IDto
    {
        public int QuestionCategoryId { get; set; }

        public int ExamId { get; set; } //hangi sınava ekleyeceği seçilmesi için

        public string ExamName { get; set; }
        public string QuestionCategoryName { get; set; }






    }
}
