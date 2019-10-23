using System;

class Hamburguer : Alimento{
  private float custo=5.25f;
  private int qtdBife = 1;
  private int salada=1;
  private int pao=2;
  private int ovo =1;
  private float preco;

  public void setAdicional(int bife=1, int salada=1,int ovo =0){
    this.qtdBife*=bife;
    this.salada*=salada;
    this.ovo*=ovo;
  }

  public float getPreco(){
    if (qtdBife==1 && salada == 1 && pao == 2 && ovo==1)
      this.preco =8.0f;
    else{
      float precoAdSalada=1*this.salada;
      custo+= 0.5f*this.salada;
      float precoAdHamb =2.5f*this.qtdBife;
      custo+= 1.25f*this.qtdBife;
      float precoAdOvo=1*this.ovo;
      custo+= 0.3f*this.ovo;
      this.preco= 8 + precoAdHamb+precoAdSalada+precoAdOvo;
    }
    Grava.GravaCusto(custo);
    Grava.GravaLucroBruto(preco);
    return preco;
  }

  public void setNome(string name){
    nome = name;
  }

  public void Retorno(){
    Console.WriteLine("======================= {0} ========================",nome);
    Console.WriteLine("Preco Inicial: 8R$\nAdicionais: {0}-Saladas {1}-Bifes {2}-Ovos",salada-1,qtdBife-1, ovo-1);
    Console.WriteLine("======================= Preco final com os adicionais: {0} R$ =========================",getPreco());
  }
}