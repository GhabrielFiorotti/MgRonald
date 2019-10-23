using System;

class Hamburguer : Alimento{
  private float custo=5.25f;
  private int qtdBife = 1;
  private int salada=1;
  private int pao=2;
  private int ovo =0;
  private float preco;

  public void setAdicional(int bife=1, int salada=1,int ovo =0){
    this.qtdBife*=bife;
    this.salada*=salada;
  }

  public float getPreco(){
    if (qtdBife==1 && salada == 1 && pao == 2 && ovo==0)
      preco =8.0f;
    else{
      float precoAdSalada=1*this.salada;
      custo+= 0.5f*this.salada;
      float precoAdHamb =2.5f*this.qtdBife;
      custo+= 1.25f*this.qtdBife;
      float precoAdOvo=1*this.ovo;
      custo+= 0.3f*this.ovo;
      preco= 8 + precoAdHamb+precoAdSalada;
    }
    Grava.GravaCusto(custo);
    Grava.GravaLucroBruto(preco);
    return preco;
  }

  public void SetNome(string name){
    nome = name;
  }

  public void Retorno(){
    Console.WriteLine("======================= {0} ========================",nome);
    Console.WriteLine("Hamburguer\nPreco Inicial: 8R$\nAdicionais: {0}-saladas {1}-Bifes",salada,qtdBife);
    Console.WriteLine("======================= Preco: {0} =========================",preco);
  }
}