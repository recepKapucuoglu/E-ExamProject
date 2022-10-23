using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;

namespace Business.Concrete
{
    public class ExamManager:IExamService
    {
        IExamDal _examDal;

        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }


        public IResult Add(Exam exam)
        {

            // kullanıcının categoriyi sınav ekleme ekranında girme kodu



            Exam _exam = new Exam
            {
              CategoryId= exam.CategoryId,//kategorisini checkboxtan seçecek // categorilistesini checkboxtan vericez.
              Name = exam.Name, 
              Time = exam.Time,
              Description = exam.Description,   
              Point = exam.Point,   

            };
          
            _examDal.Add(_exam);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Exam exam) 
        {
            _examDal.Delete(exam);
         return   new SuccessResult( Messages.Deleted);
        }

        //kullanıcının tüm sınavları listelemesi yapıldı. // buna gerek yok 
        public IDataResult<List<ExamDetailDto>> GetAll()
        {
            var result =_examDal.ExamDetailDto();
            return new SuccessDataResult<List<ExamDetailDto>>(result);
        }



        public IDataResult<List<ExamDetailDto>> GetAllByCategoryId(int id) //kullanıcının seçtiği kategorideki sınavlar listenecek.
        {
          var result=  _examDal.ExamDetailDto(p=>p.CategoryId==id);  
            return new SuccessDataResult<List<ExamDetailDto>>(result);
        }


       
        public IDataResult<List<Exam>> GetExam(int id) // seçilen sınavın sorularını getirir
        {
           var  result = _examDal.GetExamQuestion(p=>p.Id==1);
            return new SuccessDataResult<List<Exam>>(result);
        }

        public IResult Update(Exam exam)
        {
            _examDal.Update(exam);
            return new SuccessResult(Messages.Updated);
        }


    }
}
