using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class QuestionType:IEntity
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual   List<Question> Questions { get; set; }


        public QuestionType()
        {
            Questions = new List<Question>();
        }
    }
}
