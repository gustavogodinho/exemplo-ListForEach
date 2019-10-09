using System;
using System.Collections.Generic;

namespace ExemploForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> names = new List<Funcionario>();

            names.Add(new Funcionario() {ID = 1,Nome = "Bruce"});
            names.Add(new Funcionario() {ID = 1,Nome = "Alfred"});
            names.Add(new Funcionario() {ID = 1,Nome = "Tim"});
            names.Add(new Funcionario() {ID = 1,Nome = "Richard"});
            names.Add(new Funcionario() {ID = 1,Nome = "Gustavo"});
      
    
        names.ForEach(delegate(Funcionario func)
        {
          System.Console.WriteLine(func);
        });

        names.ForEach((s)=> {
            s.ID = 100;
            s.Nome = "Hey Ho!";
            System.Console.WriteLine(s);
        });
        }

        public class Funcionario 
        {
            public int ID { get; set; }
            public string Nome { get; set; }

        public override string ToString()
        {
            return "Id: " + ID + " Nome: " + Nome;
        }

        }

          
    }
}
