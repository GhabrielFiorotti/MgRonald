using System;
using System.Threading;
using System.Collections.Generic;

class PizzaBacon : Pizza{
  
  private int qtd;
  private string tipo;
  protected bool bordaRecheada;
  public bool BordaRecheada
  {
    get{return bordaRecheada;} 
    set{this.bordaRecheada=value;}
  }

  public PizzaBacon() :base() 
  {
    produtoPizza.Mussarela = 3;
    produtoPizza.Calabresa = 3;
    produtoPizza.Bacon = 3;

  }

  public void setNome(string name){
    nome = name;
  }

  private double valorBorda(){
    double valorBorda = 5;
    return valorBorda;
  }
  public void setAdicional(string tipo,int qtd)
  {
    if(tipo == "Bacon")
      produtoPizza.Catupiry =qtd;
    if(tipo == "mussarela")
      produtoPizza.Mussarela =qtd;
    if(tipo == "frango")
      produtoPizza.Frango = qtd;
  }
  public void retorno(){
    if(bordaRecheada){
      double valor =valorBorda();

      valorCusto=produtoPizza.getPrecoCusto()+valor;
      Grava.GravaCusto(valorCusto);

      valorVenda=produtoPizza.getPrecoVenda()+valor;
      Grava.GravaLucroBruto(valorVenda);
    
    }else{
      valorCusto=produtoPizza.getPrecoCusto();
      Grava.GravaCusto(valorCusto);

      valorVenda=produtoPizza.getPrecoVenda();
      Grava.GravaLucroBruto(valorVenda);
    }
    Console.Clear();
    Console.WriteLine("============Pedidos=============");

    Console.WriteLine("Nome-> "+nome+"\nPreço-> "+valorVenda.ToString("N2")+"\nCalorias-> 2200\n");
  }


}