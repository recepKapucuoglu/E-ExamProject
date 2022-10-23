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
    public class OptionManager : IOptionService
    {

        IOptionDal _optionDal;

        public OptionManager(IOptionDal optionDal)
        {
            _optionDal =optionDal ;
        }


       // kullanıcı ŞIK ekleyeceği SORU seçilir..
        public IResult Add(Option option)
        {
            Option _option = new Option()
            {
                IsTrue = option.IsTrue,
                Name=option.Name,
                QuestionId=option.QuestionId,  // hangi soruya ekleyeceği seçilir.

            };
            _optionDal.Add(_option);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Option option)
        {
            _optionDal.Delete(option);
         return   new SuccessResult(Messages.Deleted);
            
        }
            
        
        public IDataResult<List<OptionDetailDto>> GetAll()
        {
            var result = _optionDal.OptionDetailDto();
          return new SuccessDataResult<List<OptionDetailDto>>(result,Messages.Listing);
        }

         

        public IResult Update(Option option)
        {
            _optionDal.Update(option);
            return new SuccessResult(Messages.Updated);
        }
    }
}
