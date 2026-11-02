using System.Windows.Documents;

namespace MVVM.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateOnly Age { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} - {Role.Name}";
        }
    }
}
