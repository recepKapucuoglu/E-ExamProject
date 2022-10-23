using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserExamManager : IUserExamService
    {
        IUserExamDal _userExamDal;

        public UserExamManager(IUserExamDal userExamDal)
        {
            _userExamDal = userExamDal;
        }

        public IDataResult<List<UserExam>> GetExamForUser(int userId)
        {
            var result =  _userExamDal.GetExamQuestion(p=>p.UserId == 1);
            return new SuccessDataResult<List<UserExam>>(result,"Sınav gösterime başarıyla açıldı");
        }
    }
}
