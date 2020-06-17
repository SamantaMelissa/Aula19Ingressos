using System;
namespace Aula19Ingressos
{
    public class IngressoVIP : Ingressos
    {
       public float ValorAdicional = 50.0f;

       public void AdicionarValor(){
           float newValor = IngressoPreco + ValorAdicional;
           
           System.Console.WriteLine("O valor para entrada VIP é de $"+newValor);
       } 
    }
}