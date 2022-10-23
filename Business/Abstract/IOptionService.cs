using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOptionService
    {
        IDataResult<List<OptionDetailDto>> GetAll();

        IResult Add(Option option);

        IResult Delete(Option option);

        IResult Update(Option option);
    }
}
