using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IExamService
    {
        IDataResult<List<ExamDetailDto>> GetAll();

        IResult Add(Exam exam);

        IResult Delete(Exam exam);

        IResult Update(Exam exam);

        IDataResult<List<ExamDetailDto>> GetAllByCategoryId(int id);

        IDataResult <List<Exam>> GetExam(int id); //seçilen sınavın sorularını listeler.

    }
}
