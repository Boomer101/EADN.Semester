﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistence = EADN.Semester.QuizGame.Persistence;

namespace EADN.Semester.QuizGame.Persistence.EF
{
    public class QuizGameContext : DbContext
    {
        public QuizGameContext() : base("name=QuizGameDBConnectionString")
        { }

        public DbSet<Quiz> Quiz { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Answer>()
            //        .HasRequired<Question>(a => a.)
            //        .WithMany(s => s.Students)
            //        .HasForeignKey(s => s.StdId);

            //modelBuilder.Entity<Question>()
            //    .HasMany<Topic>(q => q.Topics)
            //    .WithMany(t => t.Questions)
            //    .Map(qt =>
            //    {
            //        qt.MapLeftKey("TopicRefId");
            //        qt.MapRightKey("QuestionRefId");
            //        qt.ToTable("QuestionTopic");
            //    });
        }
    }
}
    
