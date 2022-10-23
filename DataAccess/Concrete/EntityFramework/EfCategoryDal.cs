using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ExamProjectContext>, ICategoryDal
    {
        public async void DeleteandNull(Category category)
        {
                ExamProjectContext context = new ExamProjectContext();
                
                Category _category = await context.Categories.FindAsync(category.Id);
                context.Categories.Remove(_category);
                await context.SaveChangesAsync();
            
        }
    }
}