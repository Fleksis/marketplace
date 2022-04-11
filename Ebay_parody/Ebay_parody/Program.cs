using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Ebay_parody {
    class Program {
        static void Main(string[] args) {
            QueryBuilder user = new QueryBuilder("user");
            /*
            List<List<dynamic>> data = users.Select(new string[] { "*" });
            foreach (List<dynamic> row in data) {
                foreach (dynamic cell in row) {
                    Console.Write($"{cell}\t|");
                }
                Console.WriteLine();
            }
            */

            //List<List<dynamic>> data = user.Select(new string[] { "id", "firstname" }, new dynamic[,] { { "id", 14 } });
            //List<List<dynamic>> data = user.Select(new string[] { "*" });
            /*
            foreach (List<dynamic> row in data) {
                foreach (dynamic cell in row) {
                    Console.Write($"{cell}\t|");
                }
                Console.WriteLine();
            }
            */

            /*
            //SELECT {"K�das v�rt�bas ir j�pieprasa(var ar� visu ar "*")"} | WHERE { { "column nosaukums", K�du v�rt�bu mekl� } }
            //Ieg�s datus, k�di tiks piepras�ti      
            List<List<dynamic>> data = user.Select(new string[] { "id", "firstname" }, new dynamic[,] { { "email", $"'{ email }'" } });
            //Ieg�t� v�rt�ba
            Console.WriteLine(data[0][0]);

            //UPDATE{"(identiski)lastname" "juans firstname"} { var veidot cik gribi katrai column} | WHERE { { "column nosaukums", K�du v�rt�bu mekl� } }
            //Atjaunos eso�os datus datub�z�
            user.Update(new dynamic[,] { { "db column name", "jauns nosaukums" }, { "db column name", "jauns nosaukums" } }, new dynamic[,] { { "id", 5 } });

            //INSERT {"id"(auto), "firstname", "lastname", "email", "password"}
            //Ievietos jaunus datus datub�z�
            user.Insert(new dynamic[] { "", "P�teris", "Birzi��", "asda@gmail.com", "123", "" });
            */

            string[] titles = { "Login", "Register" };
            bool isCursorCorrect = false;
            while (isCursorCorrect != true) {
                Authentication.CreateButtonList(titles, true);
                Console.Write("Choose authentication method: ");
                string cursor = Console.ReadLine();

                Console.Clear();
                switch (cursor) {
                    case "1":
                        Authentication.Login();
                        isCursorCorrect = true;
                        break;
                    case "2":
                        Authentication.Register();
                        isCursorCorrect = true;
                        break;
                    default:
                        Console.WriteLine("Not correct input...");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}