using MVVM.Models;
using System.Collections.ObjectModel;

namespace MVVM.Data
{
    public static class LocalApplicationContext
    {
        public static List<Role> Roles { get; set; } = new()
        {
            new Role()
            {
                Id = 1,
                Name = "user"
            },
            new Role()
            {
                Id = 2,
                Name = "meneger"
            },
            new Role()
            {
                Id = 2,
                Name = "admin"
            }
        };
        public static List<User> Users { get; set; } = new()
        {
            new User() { Id = 1, Name = "User 1", Email = "1@mail.ru", Login = "1", Password = "1", Role = Roles[0]},
            new User() { Id = 2, Name = "User 2", Email = "2@mail.ru", Login = "2", Password = "2", Role = Roles[1]},
            new User() { Id = 3, Name = "User 3", Email = "3@mail.ru", Login = "3", Password = "3", Role = Roles[2]}
        };
        public static ObservableCollection<Product> Products { get; set; } = new()
        {
            new Product(){ Id = 1, Count = 10, Description = "description 1", Discont = 15, Name = "name 1", Price = 9999, ImagePath="Source/Images/default.png"},
            new Product(){ Id = 2, Count = 14, Description = "description 2", Discont = 0, Name = "name 2", Price = 1, ImagePath="Source/Images/default.png"},
        };
    
    }
}
