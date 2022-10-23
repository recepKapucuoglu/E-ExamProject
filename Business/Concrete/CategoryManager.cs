using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _CategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            Category _category = new Category()
            {
                Name = category.Name,
            };
          //  _category.Exams.Add( new Exam() { Name=examDetailDto.Name, Description=examDetailDto.Description,Time=examDetailDto.Time,Point=examDetailDto.Point  });

            _CategoryDal.Add(_category);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Category category)
        {
            _CategoryDal.Delete(category);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = _CategoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(result, Messages.Listing);
        }

        public IResult Update(Category category)
        {
           
            _CategoryDal.Update(category);
            return new SuccessResult(Messages.Updated);
        }
    }
}
