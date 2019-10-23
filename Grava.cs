using System;
using System.IO;
using System.Text;

public static class Grava{
  public static void GravaCusto(float custo){
    FileStream arquivo = new FileStream("Custo.txt",FileMode.Append,FileAccess.Write);
  
    StreamWriter sw = new StreamWriter(arquivo,Encoding.UTF8);
    sw.WriteLine(custo);

    sw.Close();
    arquivo.Close();
  }
    public static void GravaLucroBruto(float lucro){
    FileStream arquivo = new FileStream("Lucro.txt",FileMode.Append,FileAccess.Write);

    StreamWriter sw = new StreamWriter(arquivo,Encoding.UTF8);
    sw.WriteLine(lucro);

    sw.Close();
    arquivo.Close();
  }
}