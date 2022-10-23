using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<QuestionDetailDto>> GetAll();

        IDataResult<List<QuestionDetailDto>> GetAllByQCategoryId(int id);

        IDataResult<List<Question>> GetAllQuestionOptions();
        IResult Add(Question question);

        IResult Delete(Question question);

        IResult Update(Question question);
    }
}
