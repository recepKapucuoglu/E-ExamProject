using Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Entities.Concrete
{
    public class Question:IEntity
    {
        public int Id { get; set; }

        public int? QuestionTypeId { get; set; }

        public int? QuestionCategoryId { get; set; }
        public string Name { get; set; }

        public virtual QuestionCategory QuestionCategory { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        public virtual List<Option> Options { get; set; }

        public Question()
        {
            Options = new List<Option>();   
        }
    
    }
}
