using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class ExamProjectContext:DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=examprojedata;Trusted_Connection=true");

           

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //n-n

            //modelBuilder.Entity<QuestionOption>()
            //    .HasKey(qo => new { qo.QuestionId, qo.OptionId });
            //modelBuilder.Entity<QuestionOption>()
            //    .HasOne(qo => qo.Option)
            //    .WithMany(o => o.Questions)
            //    .HasForeignKey(qo => qo.OptionId);
            //modelBuilder.Entity<QuestionOption>()
            //   .HasOne(qo => qo.Question)
            //   .WithMany(q => q.Options)
            //   .HasForeignKey(qo => qo.QuestionId);

            modelBuilder.Entity<UserExam>()
                .HasKey(ue => new { ue.UserId, ue.ExamId });
            modelBuilder.Entity<UserExam>()
                .HasOne(ue => ue.Exam)
                .WithMany(o=>o.Users)
                .HasForeignKey(ue => ue.ExamId);
            modelBuilder.Entity<UserExam>()
              .HasOne(q => q.User)
              .WithMany(e => e.Exams)
              .HasForeignKey(q => q.UserId);



            //1-n ilişkiler

            modelBuilder.Entity<Exam>()
                .HasOne(c => c.Category)
                .WithMany(d => d.Exams)
                .OnDelete(DeleteBehavior.Cascade);
            //.OnDelete(DeleteBehavior.SetNull) //princibal tablodan silinen veri olursa ilişkili tablolarını NULL Yap.
            //.IsRequired(false);

            modelBuilder.Entity<Question>()
                .HasOne(c => c.QuestionCategory)
                .WithMany(d => d.Questions)
                .OnDelete(DeleteBehavior.Cascade);

            //.OnDelete(DeleteBehavior.SetNull)
            //.IsRequired(false);
            modelBuilder.Entity<Question>()
                .HasOne(c => c.QuestionType)
                .WithMany(d => d.Questions)
            .HasForeignKey(c => c.QuestionTypeId)
            .OnDelete(DeleteBehavior.Cascade);

            //        .OnDelete(DeleteBehavior.SetNull)

            //.IsRequired(false);
            modelBuilder.Entity<QuestionCategory>()
              .HasOne(qc => qc.Exam)
              .WithMany(d => d.QuestionCategories)
              .HasForeignKey(qc => qc.ExamId)
              .OnDelete(DeleteBehavior.Cascade);

            //.OnDelete(DeleteBehavior.SetNull)
            //.IsRequired(false);

            modelBuilder.Entity<Option>()
                .HasOne(e => e.Question)
                .WithMany(d => d.Options)
                .HasForeignKey(e => e.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);

            //.OnDelete(DeleteBehavior.SetNull)
            //.IsRequired(false);



        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Exam> Exams { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<QuestionCategory> QuestionCategories { get; set; }


        public DbSet<QuestionType> QuestionTypes { get; set; }

        public DbSet<UserExam> UserExam { get; set; }




    }
}
