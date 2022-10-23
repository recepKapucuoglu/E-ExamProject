using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionCategoryService
    {
        IDataResult<List<QuestionCategoryDetailDto>> GetAll();

        IDataResult<List<QuestionCategoryDetailDto>> GetAllByExam(int id);

        IResult Add(QuestionCategoryDetailDto questionCategoryDetailDto);


        IResult Delete(QuestionCategory questionCategory);

        IResult Update(QuestionCategory questionCategory);
    }
}

//admin ilk önce kategori oluşturur . listeler düzenler siler.

// sınav oluşturacagı zaman kategori seçmesi istenir. --- ilgili kategori yoksa eklemesi istenir.  