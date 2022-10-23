using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Exam:IEntity
    {
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        public string Name { get; set; }

        public int Time { get; set; }

        public string Description { get; set; }

        public int? Point { get; set; }

        public  virtual Category Category { get; set; }

        public virtual List<QuestionCategory> QuestionCategories { get; set; }

        public virtual List<UserExam> Users { get; set; }
        public Exam()
        {
            Users = new List<UserExam>();   
          
            QuestionCategories = new List<QuestionCategory>();
        }
    }
}
