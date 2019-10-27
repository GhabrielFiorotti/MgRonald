using System;

class Alimento{
  protected string nome;
  public string Nome 
    {
      get{return nome;}
      set{nome=value;}
    }
  
  protected bool comestivel = true;  
  public bool Cosmestivel
    {
      get{return comestivel;}
      set{comestivel= value;}
    }
} 