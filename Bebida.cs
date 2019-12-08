using System;

class Bebidas : Gelados
{
    private float preco;
    private float qtd;
    private string tipo;
    private float custo;

    public void setTipo(string tipo)
    {
        if (tipo == "Refrigerante")
        {
            this.tipo = tipo;
            this.preco = 3 + qtd;
            this.custo = 2.60f;
            Grava.GravaCusto(custo);
            Grava.GravaLucroBruto(preco);
        }
        else if (tipo == "Suco")
        {
            this.tipo = tipo;
            this.preco = 5f + qtd;
            this.custo = 4f;
            Grava.GravaCusto(custo);
            Grava.GravaLucroBruto(preco);
        }
        else if (tipo == "Cerveja")
        {
            this.tipo = tipo;
            this.preco = 6.50f + qtd;
            this.custo = 4;
            Grava.GravaCusto(custo);
            Grava.GravaLucroBruto(preco);
        }
    }

    public void setQuantidade(int quanti)
    {
        if (quanti == 1)
            this.qtd = 3f;
        else if (quanti == 2)
            this.qtd = 5.5f;
        else
            this.qtd = 10f;
    }

    public void setNome(string tipo)
    {
        nome = tipo;
    }

    public void Retorno()
    {
        Console.WriteLine("================ {0} ================", this.nome);
        Console.WriteLine("Bebida\nTipo - {0}", tipo);
        Console.WriteLine("============= Preço: {0} R$ ===============", preco);
    }
}