using System;

public static class Egestor{
  public static float Gestor(){
    Leitura lendo = new Leitura();      
    float lucro= lendo.lerTxtLucro();
    float custo=lendo.lerTxtCusto();

    float lucroLiquido = lucro-custo;

    float resultado= lucroLiquido/custo;  
    return (resultado)*100;
  }
}