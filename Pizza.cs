using System;

class Pizza : Alimento{
  private int tamanho;
  private float custo=18;
  private int azeitona = 1;
  private int mussarela=5;
  private int sabor=1;
  private float preco;

  public void setAdicional(int mussarela, int azeitona){
    this.mussarela+=mussarela;
    this.azeitona+=azeitona;
  }

  public void setTamanho(int tam){
      tamanho = tam;
  }
   
  public float getPreco(){
    if (azeitona==1 && mussarela == 5 && sabor == 1)
      preco =4*tamanho;
    else{
      custo += (0.1f*this.azeitona) + (0.3f*this.mussarela);
      float precoAdAzei=0.1f*this.azeitona;
      float precoAdMussa =0.5f*this.mussarela;
      preco= (4*tamanho) + precoAdMussa+precoAdAzei;
    }
    Grava.GravaCusto(custo);
    Grava.GravaLucroBruto(preco);
    return preco;
  }

 public void setNome(string name){
    nome = name;
  }

  public void Retorno(){
    Console.WriteLine("====================={0}=====================",this.nome);
    Console.WriteLine("Tamanho: {2} pedaços \nAdicionais: {0}-Azeitona {1}-Mussarela",azeitona,mussarela, tamanho);
    Console.WriteLine("===================Preco : {0}===================",getPreco());
  }
}