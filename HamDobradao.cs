using System;

class HamDobradao : Hamburguer
{
    private int qtd;
    private string tipo;
    private bool acompanhamentoAleatorio;
    public bool AcompanhamentoAleatorio
    {
        get { return acompanhamentoAleatorio; }
        set { this.acompanhamentoAleatorio = value; }
    }

    public void setNome(string name)
    {
        nome = name;
    }

    public HamDobradao() : base()
    {
        produtoHamburguer.Bife = 2;
        produtoHamburguer.Alface = 2;
        produtoHamburguer.Tomate = 2;
        produtoHamburguer.Picles = 3;
        produtoHamburguer.Queijos = 3;
        produtoHamburguer.Ovo = 2;
    }

    public void setAdicional(string tipo, int qtd)
    {
        //Console.WriteLine(tipo+" - "+qtd);
        if (tipo == "bife")
            produtoHamburguer.Bife = 2 * qtd;
        else if (tipo == "alface")
            produtoHamburguer.Alface = 2 * qtd;
        else if (tipo == "tomate")
            produtoHamburguer.Tomate = 2 * qtd;
        else if (tipo == "picles")
            produtoHamburguer.Picles = 2 * qtd;
        else if (tipo == "ovo")
            produtoHamburguer.Ovo = 2 * qtd;
        else if (tipo == "queijos")
            produtoHamburguer.Queijos = 2 * qtd;
        else
            Console.WriteLine("Nâo temos esse produto\n me desculpe");
    }

    private string acompanhamento()
    {
        string[] acompa = new string[] { "Anéis de cebola", " Batata canoa assada", "Batata palha", "molhos", "Batata palito", "Balde de frango frito" };
        Random rand = new Random();
        return acompa[rand.Next(0, acompa.Length)];
    }


    public void retorno()
    {
        valorCusto = produtoHamburguer.getPrecoCusto();
        Grava.GravaCusto(valorCusto);

        valorVenda = produtoHamburguer.getPrecoVenda();
        Grava.GravaLucroBruto(valorVenda);

        if (acompanhamentoAleatorio == true)
        {
            Console.WriteLine("entrou no acompanhamento");
            string acompanhament = acompanhamento();
            Console.WriteLine("Nome-> " + nome + "\nPreço-> " + valorVenda.ToString("N2") + "\nCalorias->2400\nAcompanhamento->" + acompanhament);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Nome-> " + nome + "\nPreço-> " + valorVenda.ToString("N2") + "\nCalorias->2400\n");
        }
    }
}