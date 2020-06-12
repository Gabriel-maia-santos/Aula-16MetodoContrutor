using System;

namespace Aula16Metodoconstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
           Produto celular = new Produto(45);
            celular.Nome = "iPhone";
            System.Console.WriteLine(celular.Codigo);

            Produto camisa = new Produto("camisa :",34, "Supreme", "Azul", 234);
            System.Console.WriteLine(camisa.Tipo);
            System.Console.WriteLine(camisa.Codigo);
            System.Console.WriteLine(camisa.Nome);
            System.Console.WriteLine(camisa.Descricao);
            System.Console.WriteLine(camisa.Estoque);



            Produto celsam = new Produto("celular :",34, "Samsung", "Branco", 10);
            System.Console.WriteLine(celsam.Tipo);
            System.Console.WriteLine(celsam.Codigo);
            System.Console.WriteLine(celsam.Nome);
            System.Console.WriteLine(celsam.Descricao);
            System.Console.WriteLine(celsam.Estoque);


           }
        }
    }

