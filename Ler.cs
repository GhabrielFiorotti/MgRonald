using System;
using System.IO;
using System.Text;

class Ler {

  public float LerTxt1(){
    int conteud =0;
    int totalLucro =0;

    FileStream txtLucro = new FileStream("Lucro.txt",FileMode.Open,FileAccess.Read);
    
    StreamReader srLucro = new StreamReader(txtLucro, Encoding.UTF8);

    while(!srLucro.EndOfStream){
      conteud =int.Parse(srLucro.ReadLine());
      totalLucro+=conteud;
    }
    srLucro.Close();
    txtLucro.Close();

    return totalLucro;
  } 



  public float LerTxt2(){
    float conteud =0;
    float totalLucro =0;

    FileStream txtCusto = new FileStream("Custo.txt",FileMode.Open,FileAccess.Read);
    
    StreamReader srCusto = new StreamReader(txtCusto, Encoding.UTF8);

    while(!srCusto.EndOfStream){
      conteud =float.Parse(srCusto.ReadLine());
      totalLucro+=conteud;
    }
    srCusto.Close();
    txtCusto.Close();

    return totalLucro;
  }
}