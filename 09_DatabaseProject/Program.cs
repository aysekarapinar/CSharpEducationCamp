﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net; SQL yapılarını kullanabilmemize olanak sağlayan bir kütüphanedir.

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=AMORE;initial Catalog=EducationCampDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //C# kodları ile SQL sunucu arasında bir köprü
            DataTable dataTable = new DataTable(); //Verileri belleğe almaya sağlıyor
            adapter.Fill(dataTable); //
            connection.Close();

            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}