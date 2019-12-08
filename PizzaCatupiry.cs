using System;
using System.Threading;
using System.Collections.Generic;

class PizzaCatupiry : Pizza{
  
  private int qtd;
  private string tipo;
  protected bool bordaRecheada;
  public bool BordaRecheada
  {
    get{return bordaRecheada;} 
    set{this.bordaRecheada=value;}
  }

  public PizzaCatupiry() :base() 
  {
    produtoPizza.Catupiry = 2;
    produtoPizza.Mussarela = 3;
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
    if(tipo == "catupiry")
      produtoPizza.Catupiry =qtd;
    if(tipo == "mussarela")
      produtoPizza.Mussarela =qtd;
    if(tipo == "frango")
      produtoPizza.Frango = qtd;
    if(tipo == "palmito")
      produtoPizza.Palmito = qtd;
    if(tipo == "ovo")       
      produtoPizza.Ovo = qtd;
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
    Console.WriteLine("Nome-> "+nome+"\nPreço-> "+valorVenda.ToString("N2")+"\nCalorias-> 2000\n");
  }


}