using CloudCustomers.API.Models;
using System.Collections.Generic;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture {
        public static List<User> GetTestUsers() => new() {
            new User {
                Name = "Test User 1",
                Email = "test.user.1@example.com",
                Address = new Address {
                    Street = "123 Constructorilor",
                    City = "Bucharest",
                    ZipCode = "111111"
                }
            },
            new User {
                Name = "Test User 2",
                Email = "test.user.2@example.com",
                Address = new Address {
                    Street = "123 Aviatorilor",
                    City = "Bucharest",
                    ZipCode = "222222"
                }
            },
            new User {
                Name = "Test User 3",
                Email = "test.user.3@example.com",
                Address = new Address {
                    Street = "234 Constructorilor",
                    City = "Constanta",
                    ZipCode = "333333"
                }
            },
        };
    }
}
