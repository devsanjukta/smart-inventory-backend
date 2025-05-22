using Moq;
using SmartInventory.Core.DTOs;
using SmartInventory.Core.Interfaces;
using SmartInventory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInventory.Tests.Services
{
    public class ServiceTest
    {
        private readonly Mock<IUserRepository> _userRepoMock;
        private readonly IUserService _userService;
        public ServiceTest()
        {
            _userRepoMock = new Mock<IUserRepository>();

            // Use the interface, but still instantiate the real implementation
            _userService = new UserService(_userRepoMock.Object); // Assuming UserService implements IUserService
        }

        [Fact]
        public async Task RegisterAsync_ShouldReturnSuccess_WhenInputIsValidAndEmailIsUnique()
        {
            // Arrange
            var newUser = new AppUserRegistrationDTO
            {
                UserName = "John Doe",
                Email = "john@example.com",
                Password = "StrongP@ssw0rd"
            };

            //_userRepoMock.Setup(x => x.IsEmailUniqueAsync(newUser.Email)).ReturnsAsync(true);

            //// Act
            //var result = await _userService.RegisterAsync(newUser);

            //// Assert
            //Assert.True(result.IsSuccess);
            //Assert.Equal("Registration successful", result.Message);
        }
    }
}
