using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question, ExamProjectContext>, IQuestionDal
    {
       
        public async void DeleteandNull(Question question)
        {
            ExamProjectContext context = new ExamProjectContext();

            Question _question = await context.Questions.FindAsync(question.Id);
            context.Questions.Remove(_question);
            await context.SaveChangesAsync();

        }

        public List<QuestionDetailDto> QuestionDetailDto(Expression<Func<QuestionDetailDto, bool>> filter = null)
        {
            using (ExamProjectContext context = new ExamProjectContext())
            {
                var result = from q in context.Questions
                             join qt in context.QuestionTypes
                             on q.QuestionTypeId equals qt.Id
                             join qc in context.QuestionCategories
                             on q.QuestionCategoryId equals qc.Id

                             select new QuestionDetailDto
                             {
                                QuestionId = q.Id,
                                QuestionCategoryId=qc.Id,
                                QuestionTypeId=qt.Id,
                                QuestionCategoryName=qc.Name,
                                QuestionName=q.Name,
                                QuestionTypeName=qt.Type
                             };
                return filter == null
                                ? result.ToList()
                                   : result.Where(filter).ToList();






            }
        }

        public List<Question> GetAllQuestionOptions(Expression<Func<Question, bool>> filter = null)
        {


            using (var context = new ExamProjectContext())
            {

                var result = context.Questions
                 .Include(p => p.Options);
              

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }


        }
    }
}
