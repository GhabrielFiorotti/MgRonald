using System;

class Produto {
  private int bife=0;
  public int Bife
    {
      get { return this.bife; } set { this.bife = value;}
    }
  private int alface=0;
  public int Alface
    {
      get{return alface;} set{this.alface=value;}
    }
  private int tomate=0;
  public int Tomate
    {
      get{return tomate;} set{this.tomate=value;}
    }
  private int picles=0;
  public int Picles 
    {
      get{return picles;} set{this.picles=value;}
    }
  private int batata=0;
  public int Batata 
    {
      get{return batata;} set{this.batata=value;}
    }
  private int ovo=0; 
  public int Ovo 
    {
      get{return ovo;} set{this.ovo=value;}
    }
  private int pao=0;
  public int Pao 
    {
      get{return pao;} set{this.pao=value;}
    }  
  private int calabresa=0; 
  public int Calabresa
    {
      get{return calabresa;} set{this.calabresa=value;}
    }
  private int queijos=0;
  public int Queijos
    {
      get{return queijos;} set{this.queijos=value;}
    }
  private int azeitona=0;
  public int Azeitona
    { 
      get{return azeitona;} set{this.azeitona=value;}
    } 
  private int casquinha=0;
  public int Casquinha
    {
      get{return casquinha;} set{this.casquinha=value;}
    }
  private int banana;
  public int Banana
  {
    get{return banana;} set{this.banana=value;}
  }
  private int frango;
  public int Frango
  {
    get{return Frango;} set{this.Frango=value;}
  }
  private int oregano;
  public int Oregano{
    get{return oregano;} set{this.oregano=value;}
  } 
  private int palmito;
  public int Palmito
  {
    get{return palmito;} set{this.palmito=value;}
  }
  private int catupiry;
  public int Catupiry
  {
    get{return catupiry;} set{this.catupiry=value;}
  }
  private int massa;
  public int Massa
  {
    get{return massa;} set{this.massa=value;}
  }
  private int mussarela;
  public int Mussarela
  {
    get{return mussarela;} set{this.mussarela=value;}
  }
  private int bacon;
  public int Bacon
  {
    get{return bacon;} set{this.bacon=value;}
  }
  
  private double precoVenda;
  private double precoCusto;  

  public double getPrecoVenda(){
    this.precoVenda += 2.5f*this.bife;
    this.precoVenda+=0.3f*this.alface;
    this.precoVenda+=0.5f*this.tomate;
    this.precoVenda+=1*this.picles;
    this.precoVenda+= 1.5*this.batata;
    this.precoVenda+=1*this.ovo;
    this.precoVenda+=1.2f*this.pao;
    this.precoVenda+=2*this.calabresa;
    this.precoVenda+=1.43*this.queijos;
    this.precoVenda+=1.23*this.azeitona;
    this.precoVenda+= 3*this.casquinha;
    this.precoVenda+= 3*this.frango;  
    this.precoVenda+= 1.0*this.oregano;  
    this.precoVenda+= 1.05*this.palmito;  
    this.precoVenda+= 5*this.catupiry;  
    this.precoVenda+= 15*this.massa;
    this.precoVenda+= 5;//para o molho não achei necessario criar um elemento só para ele  
    this.precoVenda+=3*this.mussarela;
    this.precoVenda+= 1.5f*this.bacon;


    return precoVenda;
  }

  public double getPrecoCusto(){
    this.precoCusto += 2.22f*this.bife;
    this.precoCusto+=0.45f*this.alface;
    this.precoCusto+=0.63f*this.tomate;
    this.precoCusto+=1.21f*this.picles;
    this.precoCusto+= 1.53f*this.batata;
    this.precoCusto+=1.32f*this.ovo;
    this.precoCusto+=1.22f*this.pao;
    this.precoCusto+=1.745f*this.calabresa;
    this.precoCusto+=1.23f*this.queijos;
    this.precoCusto+=1.23f*this.azeitona;
    this.precoCusto+= 2.5f*this.casquinha;
    this.precoCusto+= 4*this.frango;  
    this.precoCusto+= 1.6f*this.oregano;  
    this.precoCusto+= 1*this.palmito;  
    this.precoCusto+= 5*this.catupiry;
    this.precoCusto+=3*this.mussarela;
    this.precoCusto+= 15*this.massa;
    this.precoCusto+= 1.25f*this.bacon;
      
  
    return precoCusto;
  }
}