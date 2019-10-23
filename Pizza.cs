using System;

class Pizza : Alimento{
  private float custo=12.2f;
  private int azeitona = 1;
  private int mussarela=5;
  private int sabor=1;
  private float preco;

  public void setAdicional(int mussarela, int azeitona){
    this.mussarela*=mussarela;
    this.azeitona*=azeitona;
  }
   
  public float getPreco(){
    if (azeitona==1 && mussarela == 5 && sabor == 1)
      preco =19.0f;
    else{
      float precoAdAzei=0.5f*this.azeitona;
      float precoAdMussa =1.5f*this.mussarela;
      preco= 19.0f + precoAdMussa+precoAdAzei;
    }
    return preco;
  }

 public void SetNome(string name){
    nome = name;
  }

  public void Retorno(){
    Console.WriteLine("====================={0}=====================",nome);
    Console.WriteLine("Pizza\nAdicionais: {0}-Azeitona {1}-Mussarela",azeitona,mussarela);
    Console.WriteLine("===================Preco : {0}===================",preco);
  }
}