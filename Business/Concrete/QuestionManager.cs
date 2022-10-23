using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

     

        public IResult Add(Question question)
        {    //kullanıcı giricek yada seçicek
            Question _question = new Question
            {

                Name = question.Name,// kullanıcıdan gelen
                QuestionCategoryId = question.QuestionCategoryId,//kullanıcı bir categori seçimi(frontendd de checkbox gibi) yapıcak ve seçimdeki id gelicek
                QuestionTypeId = question.QuestionTypeId,//kullanıcı frontentte checkboxtan sorutipini seçicek.



            };
            _questionDal.Add(_question);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Question question)
        {
            _questionDal.Delete(question);
            return new SuccessResult(Messages.Deleted);
        }


        //tüm soruları listeledik.
        public IDataResult<List<QuestionDetailDto>> GetAll()
        {
            var result = _questionDal.QuestionDetailDto();
            return new SuccessDataResult<List<QuestionDetailDto>>(result, Messages.Listing);
        }

        //checkboxdan secilen soru kategorisine gore soruları listeleme
       public IDataResult<List<QuestionDetailDto>> GetAllByQCategoryId(int id)
        {
            var result = _questionDal.QuestionDetailDto(p=>p.QuestionCategoryId==id);

            return new SuccessDataResult<List<QuestionDetailDto>>(result,Messages.Listing);
        }

        public IDataResult<List<Question>> GetAllQuestionOptions()
        {
         var result =   _questionDal.GetAllQuestionOptions();
            return new SuccessDataResult<List<Question>>(result, Messages.Listing);

        }

        public IResult Update(Question question)
        {
            _questionDal.Update(question);
            return new SuccessResult(Messages.Updated);
        }

    
    }
}
