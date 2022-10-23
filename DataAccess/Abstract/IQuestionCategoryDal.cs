using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IQuestionCategoryDal:IEntityRepository<QuestionCategory>
    {
        void DeleteandNull(QuestionCategory questionCategory);
        List<QuestionCategoryDetailDto> QuestionCategoryDetailDto(Expression<Func<QuestionCategoryDetailDto, bool>> filter = null);

    }
}
