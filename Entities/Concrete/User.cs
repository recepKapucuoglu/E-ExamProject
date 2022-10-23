using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BaslangıçTarihi { get; set; }

        public DateTime BitişTarihi { get; set; }

        public int? AlınanPuan { get; set; }

        public bool? BaşarılıMı { get; set; }
        public virtual List<UserExam> Exams { get; set; }

        public User()
        {
            Exams = new List<UserExam>();
        }
    }
}
