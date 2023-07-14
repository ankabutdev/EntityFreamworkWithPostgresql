namespace ConsoleApp1;

public class Program
{

    static void Main(string[] args)
    {
        Add();
        Update(3, "Anvar", "Anvar@gmail.com", "1234");
        Delete(3);
    }

    static void Delete(int id)
    {
        AppDbContext db = new AppDbContext();

        db.Users.Remove(db.Users.Where(user => user.Id == id).FirstOrDefault());
        db.SaveChanges();
    }

    static void Add()
    {
        AppDbContext db = new AppDbContext();

        db.Users.Add(new User
        {
            Name = "Test",
            Email = "Test",
            Password = "Test"
        });
    }
    static void Update(int id, string name, string email, string password)
    {
        AppDbContext db = new AppDbContext();

        var users = db.Users.ToList();
        var user = users[id];

        user.Name = name;
        user.Email = email;
        user.Password = password;

        db.SaveChanges();
    }
}