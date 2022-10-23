using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ExamDetailDto:IDto
    {
        public int ExamId { get; set; }

        public int CategoryId { get; set; }
        public string ExamCategoryName { get; set; }

        public string Name { get; set; }

        public int Time { get; set; }

        public string Description { get; set; }

        public int? Point { get; set; }
    }
}
