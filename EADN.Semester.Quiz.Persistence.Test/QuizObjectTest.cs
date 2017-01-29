﻿using System;
using EADN.Semester.Quiz.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EADN.Semester.Quiz.Persistence.Test
{
    [TestClass]
    public class QuizObjectTest
    {
        Quiz quizTestObject;
        Question quizQuestion;
        Answer quizAnswer;
        Topic quizTopic;
        List<Topic> topicList;

        [TestInitialize]
        public void InitTest()
        {
            // Arrange
            quizTestObject = new Quiz()
            {
                Id = 1,
                Name = "Question 1"
            };
            quizQuestion = new Question()
            {
                Id = 1,
                Name = "Question 1",
                Text = "What is 1+1 ?"
            };
            quizAnswer = new Answer()
            {
                Id = 1,
                Name = "Answer 1",
                AnswerText = "2",
                IsCorrect = true
            };

            quizTestObject.Question = quizQuestion;
            quizTestObject.Answers.Add(quizAnswer);
            quizTestObject.Topics.Add(new Topic()
            {
                Id = 1, Name = "Topic 1", Text ="Trivial"
            });
        }

        [TestCleanup]
        public void CleanUp()
        {

        }

        [TestMethod]
        public void TestMethod1()
        {
            // Assert
            Assert.IsTrue(quizTestObject.Answers.Count >= 1);
            Assert.IsNotNull(quizTestObject.Question);
            Assert.IsTrue(quizTestObject.Topics.Count == 1);
        }

        [TestMethod]
        public void QuizObjectHasUniqueTopics()
        {
            // Arrange
            topicList = new List<Topic>();
            // topicList.Add(new Topic { Id = 1, Name = "Topic 1", Text = "Trivial" }); -> WIP: Topic unique machen
            topicList.Add(new Topic { Id = 2, Name = "Topic 2", Text = "Topic 2 desc" });
            topicList.Add(new Topic { Id = 3, Name = "Topic 3", Text = "Topic 3 desc" });

            // Act
            foreach (Topic topicItem in topicList)
            {
                quizTestObject.Topics.Add(topicItem);
            }

            // Assert
            Assert.IsTrue(quizTestObject.Topics.Count == 3);
        }
    }
}