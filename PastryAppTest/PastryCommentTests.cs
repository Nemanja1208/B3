using B3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace PastryAppTest
{
    public class PastryCommentTests
    {
        //Checking if the Mockrepository is populated
        [Fact]
        public void CheckIfPopulated()
        {
            //Arrange
            MockPastryRepository MockPastryRepoTest = new MockPastryRepository();
            //Act
            Pastry pastry = MockPastryRepoTest.GetPastryById(3);
            var expectedname = "Cherry Pie";
            var expectedcategory = "Pies";
            //Assert
            Assert.Equal(pastry.Name, expectedname);
            Assert.Equal(pastry.Category.CategoryName, expectedcategory);
        }

        //Checking if the Average Method is working for Ratings
        [Fact]
        public void CheckAverageMethod(){
            //Arrange
           //List for the Comments
            List<Comment> comments = new List<Comment>();
            // Comments with properties
            Comment comment1 = new Comment();
            Comment comment2 = new Comment();
            Comment comment3 = new Comment();

            //Act
            //Comment nr 1
            comment1.CommentId = "1";
            comment1.CommentMessage = "Delicious";
            comment1.Created = DateTime.Now;
            comment1.PastryId = 1;
            comment1.Rating = 10;
            //Comment nr 2
            comment2.CommentId = "3";
            comment2.CommentMessage = "Perfect";
            comment2.Created = DateTime.Now;
            comment2.PastryId = 1;
            comment2.Rating = 9;
            //Comment nr 3 
            comment3.CommentId = "2";
            comment3.CommentMessage = "Nice";
            comment3.Created = DateTime.Now;
            comment3.PastryId = 1;
            comment3.Rating = 8;
            //Adding Comments to List <Comment>
            comments.Add(comment1);
            comments.Add(comment2);
            comments.Add(comment3);
            //Expected average after calculation
            var expectedaverage = 9;
            //Assert
            Assert.Equal(comments.Sum(c => c.Rating) / comments.Count(), expectedaverage);
        }
    }
}
