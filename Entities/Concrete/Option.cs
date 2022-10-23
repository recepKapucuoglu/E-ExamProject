using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Option:IEntity
    {
        public int Id { get; set; }

        public int? QuestionId { get; set; }

        public string Name { get; set; }

        public bool IsTrue { get; set; }

        public virtual Question Question { get; set; }

    }
}
