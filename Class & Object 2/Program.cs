using System;

namespace UserBootcamp
{
    class User{
        static void Main(string[] args)
        {
            UserBootcamp11 _userbootcamp11 = new UserBootcamp11();
            _userbootcamp11.NamaUser = "Surya";

            Console.WriteLine("Nama" + _userbootcamp11.NamaUser);
        }
    }

    public class UserBootcamp11
    {
        string nama;
        string role;
        int emoney;

        public string NamaUser { get; set; }

        public string RoleUser
        {
            get { return role; }
            set { role = value; }
        }

        public int Emoney
        {
            get { return emoney; }
            set { emoney = value; }
        }
    }
}