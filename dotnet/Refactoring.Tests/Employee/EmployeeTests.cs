using System;
using Xunit;

namespace Refactoring.Tests
{
    public class EmployeeTests
    {
        [Fact]
        [Trait(nameof(Refactoring.Employee.GetAreaCode), "OK")]
        public void GetAreaCode_Should_ReturnAreaCode_When_ValidPhoneNumber()
        {
            var employee = new Employee
            {
                FirstName = "Jean",
                LastName = "Dupont",
                Id = 1,
                PhoneNumber = "+33-1-23-45-67-89",
                SecuritySocialNumber = "1707533123456"
            };

            Assert.Equal("+33", employee.GetAreaCode());
        }

        [Fact]
        [Trait(nameof(Refactoring.Employee.GetAreaCode), "KO")]
        public void GetAreaCode_Should_ThrowException_When_InvalidPhoneNumber()
        {
            var employee = new Employee
            {
                FirstName = "Jean",
                LastName = "Dupont",
                Id = 1,
                PhoneNumber = "+33123456789",
                SecuritySocialNumber = "1707533123456"
            };

            Assert.ThrowsAny<Exception>(() => employee.GetAreaCode());
        }

        [Fact]
        [Trait(nameof(Refactoring.Employee.GetBirthYear), "OK")]
        public void GetBirthYear_Should_ReturnAreaCode_When_ValidSecuritySocialNumber()
        {
            var employee = new Employee
            {
                FirstName = "Jean",
                LastName = "Dupont",
                Id = 1,
                PhoneNumber = "+33-1-23-45-67-89",
                SecuritySocialNumber = "1707533123456"
            };

            Assert.Equal("70", employee.GetBirthYear());
        }

        [Fact]
        [Trait(nameof(Refactoring.Employee.GetBirthYear), "KO")]
        public void GetBirthYear_Should_ThrowException_When_InvalidSecuritySocialNumberr()
        {
            var employee = new Employee
            {
                FirstName = "Jean",
                LastName = "Dupont",
                Id = 1,
                PhoneNumber = "+33123456789",
                SecuritySocialNumber = "1843123456"
            };

            Assert.ThrowsAny<Exception>(() => employee.GetBirthYear());
        }
    }
}
