using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Business.Concrete
{
    public class QuestionCategoryManager : IQuestionCategoryService
    {
        IQuestionCategoryDal _questionCategoryDal;
        public QuestionCategoryManager(IQuestionCategoryDal questionCategoryDal)
        {
            _questionCategoryDal = questionCategoryDal;
        
        }

        
        public IResult Add(QuestionCategoryDetailDto questionCategoryDetailDto) // kullanıcı checkboxdan genel kategoriyiseçicek-sonra sınavısecicek-sonra soru kategorisi  ekleyecek
                                                                                           // soru kategorisi sayfası açıldıgında category-exam- verileri çekilicek.
                                                                                           // include ile. category .include(exam) şeklinde çek .
                                                                                           // cliente  gelen veriyi ekrana bas seçilen category ve examın içine ekleme yaptır.
         {
            QuestionCategory _questionCategory = new QuestionCategory()
            {
                Name = questionCategoryDetailDto.QuestionCategoryName,
                ExamId = questionCategoryDetailDto.ExamId,  // hangi sınava kategori ekleyeceğini seçer.
                


            };


            _questionCategoryDal.Add(_questionCategory);

            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(QuestionCategory questionCategory)
        {
           _questionCategoryDal.Delete(questionCategory);
                  return     new SuccessResult(Messages.Deleted);
        }

        //tüm soru kategorileri listelenir
        public IDataResult<List<QuestionCategoryDetailDto>> GetAll()
        {
            var result = _questionCategoryDal.QuestionCategoryDetailDto();

            return new SuccessDataResult<List<QuestionCategoryDetailDto>>(result, Messages.Listing);
        }



        //checkboxdan secilen sınavın soru kategorilerini listeleme  //
        public IDataResult<List<QuestionCategoryDetailDto>> GetAllByExam(int id)
        {
            var result = _questionCategoryDal.QuestionCategoryDetailDto(p=>p.ExamId==id);

            return new SuccessDataResult<List<QuestionCategoryDetailDto>>(result,Messages.Listing);


        }



        public IResult Update(QuestionCategory questionCategory)
        {
            _questionCategoryDal.Update(questionCategory);
            return new SuccessResult(Messages.Updated);
        }
    }
}
