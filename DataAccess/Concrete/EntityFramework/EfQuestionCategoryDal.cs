using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionCategoryDal:EfEntityRepositoryBase<QuestionCategory, ExamProjectContext>,IQuestionCategoryDal
    {
        public async void DeleteandNull(QuestionCategory questionCategory)
        {
            ExamProjectContext context = new ExamProjectContext();

            QuestionCategory _questionCategory= await context.QuestionCategories.FindAsync(questionCategory.Id);
            context.QuestionCategories.Remove(_questionCategory);
            await context.SaveChangesAsync();

        }

        public List<QuestionCategoryDetailDto> QuestionCategoryDetailDto(Expression<Func<QuestionCategoryDetailDto, bool>> filter = null)
        {
            using (ExamProjectContext context = new ExamProjectContext())
            {
                var result = from qc in context.QuestionCategories
                             join e in context.Exams
                             on qc.ExamId equals e.Id

                             select new QuestionCategoryDetailDto
                             {
                                 QuestionCategoryId=qc.Id,
                                 ExamId=e.Id,
                                 ExamName=e.Name,
                                 QuestionCategoryName=qc.Name
                                                                 
                             };
                return filter == null
                                ? result.ToList()
                                   : result.Where(filter).ToList();






            }

        }
    }
}
