using System;

class HamCalabresa : Hamburguer{
  private int qtd;
  private string tipo;
  private bool acompanhamentoAleatorio;
  public bool AcompanhamentoAleatorio
  {
    get{return acompanhamentoAleatorio;} 
    set{this.acompanhamentoAleatorio=value;}
  } 
  
  
  public void setNome(string name){
    nome = name;
  }

    public HamCalabresa() :base()
    {
      produtoHamburguer.Calabresa=1;
      produtoHamburguer.Queijos=1;
      produtoHamburguer.Ovo=1;
    }

  public void setAdicional(string tipo,int qtd)
  {
    //Console.WriteLine(tipo+" - "+qtd);
    if(tipo == "bife")
      produtoHamburguer.Bife = qtd;
    else if(tipo == "alface")
      produtoHamburguer.Alface = qtd;
    else if(tipo == "tomate")
      produtoHamburguer.Tomate = qtd;
    else if(tipo == "picles")
      produtoHamburguer.Picles = qtd;
    else if(tipo == "ovo")
      produtoHamburguer.Ovo = qtd;
    else if(tipo == "calabresa")
      produtoHamburguer.Calabresa = qtd; 
    else if(tipo == "queijos")
      produtoHamburguer.Queijos = qtd;               
                  
  }
  
  private string acompanhamento(){
    string[] acompa = new string[]{"Anéis de cebola","Batata canoa assada","Batata palha","molhos","Batata palito"};
    Random rand = new Random();
    return acompa[rand.Next(0,acompa.Length)];
  }


  public void retorno(){
    valorCusto=produtoHamburguer.getPrecoCusto();
    Grava.GravaCusto(valorCusto);

    valorVenda=produtoHamburguer.getPrecoVenda();
    Grava.GravaLucroBruto(valorVenda);

    if(acompanhamentoAleatorio == true){
      Console.WriteLine("entrou no acompanhamento");
      string acompanhament = acompanhamento();
      Console.WriteLine("============Pedidos=============");
      Console.WriteLine("Nome-> "+nome+"\nPreço-> "+valorVenda.ToString("N2")+"\nCalorias->1340\nAcompanhamento->"+acompanhament);
    }else{
      Console.Clear();
      Console.WriteLine("============Pedidos=============");
      Console.WriteLine("Nome-> "+nome+"\nPreço-> "+valorVenda.ToString("N2")+"\nCalorias->1340\n");
    }
    
  
  }

}