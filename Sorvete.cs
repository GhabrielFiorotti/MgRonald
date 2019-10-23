using System;

class Sorvete : Alimento {
  private float preco;
  private string tipo;
  private float custo;

  private void TipoSorvete(string tipo){
    if (tipo == "Casquinha") {
      this.tipo = tipo;
      this.preco= 3;
      this.custo = 1.50f;
      Grava.GravaCusto(custo);
      Grava.GravaLucroBruto(preco);
    }else if (tipo == "Copo") {
      this.tipo = tipo;
      this.preco= 2f;
      this.custo = 1f; 
      Grava.GravaCusto(custo);
      Grava.GravaLucroBruto(preco);
    }else if(tipo == "Milk Shake"){
      this.tipo = tipo;
      this.preco= 8.5f;
      this.custo = 4;
      Grava.GravaCusto(custo);
      Grava.GravaLucroBruto(preco);
    }
  }

  public void setNome(string tipo){
    nome = tipo;
  }

  public void Retorno(){
    Console.WriteLine("======================= {0} ========================",nome);
    Console.WriteLine("Bebida\n");
    Console.WriteLine("======================= Preco: {0} =========================",preco);
  }
}
