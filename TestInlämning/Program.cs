using NUnit.Framework;
using TestInlämning;
using Moq;

[TestFixture]
public class TestUserManager
{
    [Test]
    public void AddUserOnIDatabase()
    {
        //Arrange
        var mockData = new Mock<IDatabase>();
        var userManage = new UserManager(mockData.Object);
        var user = new User { userId = 1, userName = "Testing"};

        //Act
        userManage.AddUser(user);

        //Assert
        mockData.Verify(p => p.AddUser(user), Times.Once);
    }
    
    [Test]
    public void RemoveUserOnIDatabase()
    {
        // Arrange
        var mcData = new Mock<IDatabase>();
        var userManage = new UserManager(mcData.Object);

        // Act
        userManage.RemoveUser(1);

        // Assert
        mcData.Verify(p => p.RemoveUser(1), Times.Once);
    }

    [Test]
    public void GetUserOnIDatabase()
    {
        // Arrange
        var mockData = new Mock<IDatabase>();
        var userManage = new UserManager(mockData.Object);

        // Act
        userManage.GetUser(1);

        // Assert
        mockData.Verify(p => p.GetUser(1), Times.Once);
    }
}