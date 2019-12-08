using System;

class Gelados
{
    protected string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    protected bool frio = true;
    public bool Frio
    {
        get { return frio; }
        set { Frio = value; }
    }
}