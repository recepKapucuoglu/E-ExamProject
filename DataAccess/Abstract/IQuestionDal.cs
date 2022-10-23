using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IQuestionDal:IEntityRepository<Question>
    {
        List<QuestionDetailDto> QuestionDetailDto(Expression<Func<QuestionDetailDto, bool>> filter = null);

         void DeleteandNull(Question question);


        public List<Question> GetAllQuestionOptions(Expression<Func<Question, bool>> filter = null);

    }
}
