using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Abstract
{
    public interface IExamDal:IEntityRepository<Exam>
    {
        List<ExamDetailDto> ExamDetailDto(Expression<Func<ExamDetailDto, bool>> filter = null);


        public List<Exam> GetExamQuestion(Expression<Func<Exam, bool>> filter = null);



    }
}
