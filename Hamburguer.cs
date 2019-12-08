using System;

class Hamburguer
{
    protected string nome;
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    //protected float caloria;
    protected double valorCusto;
    protected double valorVenda;

    private int[] arrayQtd = new int[11];
    protected Produto produtoHamburguer = new Produto();


    public Hamburguer()
    {
        produtoHamburguer.Bife = 1;
        produtoHamburguer.Alface = 1;
        produtoHamburguer.Tomate = 1;
        produtoHamburguer.Picles = 1;
        produtoHamburguer.Pao = 1;
    }

    public void setNome(string name)
    {
        nome = name;
    }


    public void retorno()
    {
        valorCusto = produtoHamburguer.getPrecoCusto();
        Grava.GravaCusto(valorCusto);

        valorVenda = produtoHamburguer.getPrecoVenda();
        Grava.GravaLucroBruto(valorVenda);
        Console.Clear();
        Console.WriteLine("Nome-> " + nome + "\nPreço-> " + valorVenda.ToString("N2") + "\nCalorias->1200\n");
    }

}
