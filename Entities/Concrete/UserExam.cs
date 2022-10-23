using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserExam:IEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }

        public int? ExamId { get; set; }

        public virtual Exam Exam { get; set; }

        public virtual User User { get; set; }
    }
}
