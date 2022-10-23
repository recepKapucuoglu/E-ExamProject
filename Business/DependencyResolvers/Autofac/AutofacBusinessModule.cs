using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
			builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();


            builder.RegisterType<ExamManager>().As<IExamService>().SingleInstance();
            builder.RegisterType<EfExamDal>().As<IExamDal>().SingleInstance();


            builder.RegisterType<QuestionCategoryManager>().As<IQuestionCategoryService>().SingleInstance();
            builder.RegisterType<EfQuestionCategoryDal>().As<IQuestionCategoryDal>().SingleInstance();


            builder.RegisterType<QuestionManager>().As<IQuestionService>().SingleInstance();
            builder.RegisterType<EfQuestionDal>().As<IQuestionDal>().SingleInstance();

            builder.RegisterType<OptionManager>().As<IOptionService>().SingleInstance();
            builder.RegisterType<EfOptionDal>().As<IOptionDal>().SingleInstance();


            builder.RegisterType<UserExamManager>().As<IUserExamService>().SingleInstance();
            builder.RegisterType<EfUserExamDal>().As<IUserExamDal>().SingleInstance();




        }
	}
}
