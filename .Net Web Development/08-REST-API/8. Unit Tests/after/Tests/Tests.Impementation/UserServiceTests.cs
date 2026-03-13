using Implementation;
using Interfaces;
using Moq;
using Tests.Impementation.Helpers;

namespace Tests.Impementation
{
    public class UserServiceTests
    {
        [Fact]
        public void GetAll_Should_Return_All_Saved_Users()
        {

            //Arrange
            var mJwtService = new Mock<IJwtService>();
            var db = DatabaseHelper.GetDatabase();
            db.Users.Add(new Entities.User()
            {
                Id = 1,
                FirstName ="Test",
                LastName = "Test",
                Password = "test",
                Username = "Test"
            });
            db.SaveChanges();

            var sut = new UserService(db, mJwtService.Object);

            //Act
            var result = sut.GetAll();

            //Assert
            Assert.Single(result);

        }


        [Fact]
        public void Add_Should_Save_User_in_Database()
        {

            //Arrange
            var mJwtService = new Mock<IJwtService>();
            var db = DatabaseHelper.GetDatabase();

            var sut = new UserService(db, mJwtService.Object);

            //Act
            sut.Add(new Contracts.CreateUserRequest
            {
                Id = 1,
                FirstName = "Test",
                LastName = "Test",
                Password = "test",
                Username = "Test"
            });

            //Assert
            Assert.Single(db.Users);

        }
    }
}