using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using Core.Entities;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfExamDal : EfEntityRepositoryBase<Exam, ExamProjectContext>, IExamDal
    {
       
        public List<ExamDetailDto> ExamDetailDto(Expression<Func<ExamDetailDto, bool>> filter = null)
        {
            using (ExamProjectContext context = new ExamProjectContext())
            {
                var result = from e in context.Exams
                             join c in context.Categories
                             on e.CategoryId equals c.Id

                             select new ExamDetailDto
                             {  
                                 ExamId = e.Id,
                                 CategoryId=c.Id,
                                 Name=e.Name,
                                 Time =e.Time,
                                 Description = e.Description,
                                 Point = e.Point,
                                 ExamCategoryName=c.Name   

                             };
                    
                
                return filter == null
                                ? result.ToList()         
                                   : result.Where(filter).ToList();
               





            }
        }
        // sınava giren kullanıcılar.
        public List<Exam> GetExamQuestion(Expression<Func<Exam, bool>> filter = null)
        {


            using (var context = new ExamProjectContext())
            {

                var result = context.Exams
                 .Include(p => p.QuestionCategories)
                  .ThenInclude(p => p.Questions)
                  .ThenInclude(p => p.Options);

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }


        }
    }
}
