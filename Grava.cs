using System;
using System.IO;
using System.Text;

public static class Grava{
  public static void GravaCusto(double custo){
    FileStream arquivo = new FileStream("Custo.txt",FileMode.Append,FileAccess.Write);
  
    StreamWriter sw = new StreamWriter(arquivo,Encoding.UTF8);
    sw.WriteLine(custo);

    sw.Close();
    arquivo.Close();
  }
    public static void GravaLucroBruto(double lucro){
    FileStream arquivo = new FileStream("Lucro.txt",FileMode.Append,FileAccess.Write);

    StreamWriter sw = new StreamWriter(arquivo,Encoding.UTF8);
    sw.WriteLine(lucro);

    sw.Close();
    arquivo.Close();
  }
}



/*classe dos alimentos que terá valor dos alimentos que instaciará em todos os objetos 

fazer graficos minimo 2

criação de aliementos filhos dos próprios alimentos
ex: filho do hamburguer => hamburguer bacon  


mudar nome de classes

mudar nome das variaveis
*/