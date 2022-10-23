using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserExamDal : EfEntityRepositoryBase<UserExam, ExamProjectContext>, IUserExamDal
    {
        public List<UserExam> GetExamQuestion(Expression<Func<UserExam, bool>> filter = null)
        {

            using (var context = new ExamProjectContext())
            {

                var result = context.UserExam
                   .Include(p => p.Exam)
                  .ThenInclude(p => p.QuestionCategories)
                  .ThenInclude(p => p.Questions)
                  .ThenInclude(p => p.Options);

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }

        }
    }
}
