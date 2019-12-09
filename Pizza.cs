using System;

class Pizza{
  protected string nome;
  public string Nome 
    {
      get{return nome;}
      set{nome=value;}
    }
  //protected float caloria;
  protected double valorCusto;
  protected double valorVenda;
  protected Produto produtoPizza = new Produto();

  
  public Pizza(){
    produtoPizza.Massa = 1;
    produtoPizza.Queijos = 6;
    produtoPizza.Tomate = 4;
    produtoPizza.Palmito = 2;
    produtoPizza.Ovo = 2;
  }

  public void setNome(string name){
    nome = name;
  }

  public void retorno(){
    valorCusto=produtoPizza.getPrecoCusto();
    Grava.GravaCusto(valorCusto);

    valorVenda=produtoPizza.getPrecoVenda();
    Grava.GravaLucroBruto(valorVenda);
    Console.Clear();
    Console.WriteLine("============Pedidos=============");

    Console.WriteLine("Nome-> "+nome+"\nPreço-> "+valorVenda.ToString("N2")+"\nCalorias-> 1200\n");
  }

}
