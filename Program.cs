
using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Produto produto = new Produto("TV",500.00,10);
            Console.WriteLine(produto.GetNome());


        }
    }
}