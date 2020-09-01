using Xunit;
using AthenaeumLibrary;

namespace AthenaeumTests.AthenaeumLibrary
{

    public class ModelTests
    {
        [Fact]
        public void UserModel()
        {
            UserModel Test = new UserModel();

            Test.Name = "Test";
            Test.Notes = "123";

            Assert.False(Test.Name == "");
            Assert.True(Test.Notes == "123");
        }

        [Fact]
        public void BookModel()
        {
            BookModel Test = new BookModel();

            Assert.False(Test.Title == "Title");
            Assert.False(Test.Author == "Author");
            Assert.False(Test.Rating == 5);
            Assert.False(Test.Review == "Review");
            Assert.False(Test.Notes == "Notes");
            Assert.False(Test.Category == "Category");

            Test.Title = "Title";
            Test.Author = "Author";
            Test.Rating = 5;
            Test.Review = "Review";
            Test.Notes = "Notes";
            Test.Category = "Category";

            Assert.True(Test.Title == "Title");
            Assert.True(Test.Author == "Author");
            Assert.True(Test.Rating == 5);
            Assert.True(Test.Review == "Review");
            Assert.True(Test.Notes == "Notes");
            Assert.True(Test.Category == "Category");
        }
    } 

}
