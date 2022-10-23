using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserExamDal:IEntityRepository<UserExam>
    {
        public List<UserExam> GetExamQuestion(Expression<Func<UserExam, bool>> filter = null);

    }
}
