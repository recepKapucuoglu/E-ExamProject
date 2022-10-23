using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public virtual List<Exam> Exams { get; set; }

        public Category()
        {
            Exams = new List<Exam>();
        }
    }
}
