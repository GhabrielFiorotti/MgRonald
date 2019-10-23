using System;

public static class Egestor{
  public static float Gestor(){
    Ler lendo = new Ler();      
    float lucro= lendo.LerTxt1();
    float custo=lendo.LerTxt2();

    float lucroLiquido = lucro-custo;

    float resultado= lucroLiquido/custo;  
    return (resultado)*100;
  }
}