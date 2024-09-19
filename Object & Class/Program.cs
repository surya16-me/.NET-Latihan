using System;

namespace UserManagement {
    class User
    {
        //Atribut
        string nama = "William";
        string role = "CEO";
        int emoney = 1000000000;

        //Method
        public void UserDetail()
        {
            Console.WriteLine("ini detail usernya");
        }

        //Membuat object
        static void Main(string[] args)
        {
            //kelas itu merupakan blueprint dari objek
            User userBootcamp = new User();
            userBootcamp.UserDetail();
            Console.WriteLine("Nama : " + userBootcamp.nama);
            Console.WriteLine("Role : " + userBootcamp.role);
            Console.WriteLine("E-Money : " + userBootcamp.emoney);
        }
    }
}