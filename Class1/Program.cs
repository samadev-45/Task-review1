namespace Class1
{
    public class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Login> login = new List<Login>
            {
                new Login {Username = "Shyam", Password="12345"},
                new Login {Username = "Sam", Password = "1234"},
                new Login {Username = "Saran", Password = "123"}
            };

            Console.WriteLine("Enter Username:");
            var input = Console.ReadLine();
            Console.WriteLine("\nPassword:");
            var pass = Console.ReadLine();

            var foundUser = login.FirstOrDefault(u =>
             u.Username == input && u.Password == pass);




            if (foundUser != null)
            {
                Console.WriteLine("Login Successfully ");
            }
            else
            {
                Console.WriteLine("Login Failed ");
            }
        }
    }
}
