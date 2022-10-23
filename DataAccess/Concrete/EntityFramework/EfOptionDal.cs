using Core.DataAccess.EntityFramework;
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
    public class EfOptionDal : EfEntityRepositoryBase<Option, ExamProjectContext>, IOptionDal
    {
        public List<OptionDetailDto> OptionDetailDto(Expression<Func<OptionDetailDto, bool>> filter = null)
        {

            using (ExamProjectContext context = new ExamProjectContext())
            {
                var result = from o in context.Options
                             join q in context.Questions
                             on o.QuestionId equals q.Id

                             select new OptionDetailDto
                             {      
                                  QuestionId = q.Id,
                                  OptionId= o.Id,
                                  OptionName = o.Name,
                                  QuestionName = q.Name,
                                  IsTrue=o.IsTrue,
                                

                             };
                return filter == null
                                ? result.ToList()
                                   : result.Where(filter).ToList();






            }
        }
    }
}
