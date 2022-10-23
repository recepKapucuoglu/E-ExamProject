using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class QuestionCategory:IEntity
    {
        public int Id { get; set; }

        public int? ExamId { get; set; }
        public string Name { get; set; }

        public virtual Exam Exam { get; set; }
        public virtual List<Question> Questions { get; set; }

        public QuestionCategory()
        {
            Questions=new List<Question>(); 
        }
    }
}
