using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Xunit;

namespace CRUD_application_2.Tests.Controllers
{
    public class UserControllerTests
    {
        [Fact]
        public void Index_ReturnsViewWithUserList()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(userlist, result.Model);
        }

        [Fact]
        public void Details_WithValidId_ReturnsViewWithUser()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;
            var expectedUser = userlist.FirstOrDefault(u => u.Id == 1);

            // Act
            var result = controller.Details(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedUser, result.Model);
        }

        [Fact]
        public void Details_WithInvalidId_ReturnsHttpNotFound()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;

            // Act
            var result = controller.Details(3) as HttpNotFoundResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Create_WithValidModel_RedirectsToIndex()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>();
            UserController.userlist = userlist;
            var user = new User { Id = 1, Name = "John", Email = "john@example.com" };

            // Act
            var result = controller.Create(user) as RedirectToRouteResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.RouteValues["action"]);
        }

        [Fact]
        public void Create_WithInvalidModel_ReturnsViewWithModel()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>();
            UserController.userlist = userlist;
            var user = new User { Id = 1, Name = "", Email = "john@example.com" };

            // Act
            var result = controller.Create(user) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(user, result.Model);
        }

        [Fact]
        public void Edit_WithValidId_ReturnsViewWithUser()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;
            var expectedUser = userlist.FirstOrDefault(u => u.Id == 1);

            // Act
            var result = controller.Edit(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedUser, result.Model);
        }

        [Fact]
        public void Edit_WithInvalidId_ReturnsHttpNotFound()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;

            // Act
            var result = controller.Edit(3) as HttpNotFoundResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Edit_WithValidModel_RedirectsToIndex()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;
            var user = new User { Id = 1, Name = "Updated John", Email = "updatedjohn@example.com" };

            // Act
            var result = controller.Edit(1, user) as RedirectToRouteResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.RouteValues["action"]);
        }

        [Fact]
        public void Delete_WithValidId_ReturnsViewWithUser()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;
            var expectedUser = userlist.FirstOrDefault(u => u.Id == 1);

            // Act
            var result = controller.Delete(1) as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedUser, result.Model);
        }

        [Fact]
        public void Delete_WithInvalidId_ReturnsHttpNotFound()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;

            // Act
            var result = controller.Delete(3) as HttpNotFoundResult;

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void Delete_WithValidId_RedirectsToIndex()
        {
            // Arrange
            var controller = new UserController();
            var userlist = new List<User>
            {
                new User { Id = 1, Name = "John", Email = "john@example.com" },
                new User { Id = 2, Name = "Jane", Email = "jane@example.com" }
            };
            UserController.userlist = userlist;

            // Act
            var result = controller.Delete(1, null) as RedirectToRouteResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Index", result.RouteValues["action"]);
        }
    }
}
