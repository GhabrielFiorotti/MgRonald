using System;

class Bebidas : Alimento {
  private float preco;
  private float qtd;
  private string tipo;
  private float custo;

  private void EscolherTipo(string tipo){

    if (tipo == "Refrigerante") {
      this.tipo = tipo;
      this.preco= 5;
      this.custo = 3.0f;
      Grava.GravaCusto(custo);
      Grava.GravaLucroBruto(preco);
    }else if (tipo == "Suco") {
      this.tipo = tipo;
      this.preco= 8.5f;
      this.custo = 5.3f; 
      Grava.GravaCusto(custo);
      Grava.GravaLucroBruto(preco);
    }else if(tipo == "Cerveja"){
      this.tipo = tipo;
      this.preco= 8.5f;
      this.custo = 4;
      Grava.GravaCusto(custo);
      Grava.GravaLucroBruto(preco);
    }
  }

  private void setQuantidade(float qtd){
    this.qtd=qtd;
  }

  public void SetNome(string tipo){
    nome = tipo;
  }

  public void Retorno(){
    Console.WriteLine("======================= {0} ========================",nome);
    Console.WriteLine("Bebida\n");
    Console.WriteLine("======================= Preco: {0} =========================",preco);
  }
}