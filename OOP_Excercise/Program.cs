using System;
using System.Collections.Generic;

namespace OOPExercise
{
    // Class User (parent)
    public class User
    {
        // Properti yang dienkapsulasi
        private string nama;
        private string role;
        private double eMoney;

        // Constructor untuk User
        public User(string nama, string role, double eMoney)
        {
            this.nama = nama;
            this.role = role;
            this.eMoney = eMoney > 0 ? eMoney : 0;  // Validasi saldo awal
        }

        // Getter untuk Nama
        public string Nama
        {
            get { return nama; }
        }

        // Getter untuk Role
        public string Role
        {
            get { return role; }
        }

        // Getter untuk eMoney (Customer hanya bisa melihat saldo)
        public double EMoney
        {
            get { return eMoney; }
        }

        // Method untuk menambah saldo (hanya Admin yang bisa memanggil ini)
        protected void TambahSaldo(double jumlah)
        {
            if (jumlah > 0)
            {
                eMoney += jumlah;
                Console.WriteLine($"Saldo berhasil ditambah, saldo sekarang: {eMoney}");
            }
            else
            {
                Console.WriteLine("Jumlah harus positif.");
            }
        }

        // Method untuk Admin menambah saldo ke Customer
        public void TambahSaldoCustomer(User customer, double jumlah)
        {
            if (role == "Admin")
            {
                customer.TambahSaldo(jumlah);
            }
            else
            {
                Console.WriteLine("Hanya Admin yang dapat menambah saldo.");
            }
        }
    }

    // Class Admin (child)
    public class Admin : User
    {
        // Constructor untuk Admin
        public Admin(double eMoney) : base("Admin", "Admin", eMoney) { }
    }

    // Class Customer (child)
    public class Customer : User
    {
        // Constructor untuk Customer
        public Customer(string nama, double eMoney) : base(nama, "Customer", eMoney) { }
    }

    // Program untuk menguji kelas User, Admin, dan Customer
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance Customer
            Customer william = new Customer("William", 1000);
            Customer surya = new Customer("Surya", 1000);

            List<Customer> customers = new List<Customer> { william, surya };

            // Meminta input untuk menentukan role
            Console.WriteLine("Masukkan role Anda (Admin/Customer): ");
            string role = Console.ReadLine();

            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                // Admin role
                Admin admin = new Admin(5000);

                // Tambah saldo ke customer
                Console.WriteLine("Pilih customer (William/Surya): ");
                string customerName = Console.ReadLine();
                Customer selectedCustomer = customers.Find(c => c.Nama.Equals(customerName, StringComparison.OrdinalIgnoreCase));

                if (selectedCustomer != null)
                {
                    Console.WriteLine("Masukkan jumlah saldo yang ingin ditambahkan: ");
                    double jumlahSaldo = Convert.ToDouble(Console.ReadLine());
                    admin.TambahSaldoCustomer(selectedCustomer, jumlahSaldo);
                    Console.WriteLine($"Saldo: {selectedCustomer.EMoney}");
                }
                else
                {
                    Console.WriteLine("Customer tidak terdaftar.");
                }
            }
            else if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase))
            {
                // Customer role
                Console.WriteLine("Masukkan nama customer Anda: ");
                string customerName = Console.ReadLine();
                Customer selectedCustomer = customers.Find(c => c.Nama.Equals(customerName, StringComparison.OrdinalIgnoreCase));

                if (selectedCustomer != null)
                {
                    // Tampilkan saldo customer
                    Console.WriteLine($"Saldo: {selectedCustomer.EMoney}");
                }
                else
                {
                    Console.WriteLine("Customer tidak terdaftar.");
                }
            }
            else
            {
                Console.WriteLine("Role tidak valid.");
            }
        }
    }
}