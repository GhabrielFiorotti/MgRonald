using System;

class Sorvete : Gelados
{
    private float preco;
    private string tipo;
    private float custo;

    public void setTipo(string tipo)
    {
        if (tipo == "Casquinha")
        {
            this.tipo = tipo;
            this.preco = 3;
            this.custo = 1.50f;
            Grava.GravaCusto(custo);
            Grava.GravaLucroBruto(preco);
        }
        else if (tipo == "Copo")
        {
            this.tipo = tipo;
            this.preco = 2f;
            this.custo = 1f;
            Grava.GravaCusto(custo);
            Grava.GravaLucroBruto(preco);
        }
        else if (tipo == "MilkShake")
        {
            this.tipo = tipo;
            this.preco = 8.5f;
            this.custo = 4;
            Grava.GravaCusto(custo);
            Grava.GravaLucroBruto(preco);
        }
    }

    public void setNome(string tipo)
    {
        nome = tipo;
    }

    public void Retorno()
    {
        Console.WriteLine("============== {0} ==============", this.nome);
        Console.WriteLine("Tipo: {0}", this.tipo);
        Console.WriteLine("============= Preço: {0} R$ ============", this.preco);
    }
}
