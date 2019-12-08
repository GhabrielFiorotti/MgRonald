using System;
using System.Threading;
using System.Collections.Generic;

class MainClass
{
  public static void mostrarError(){
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Digite os comandos corretamente\n");
  }

    public static void Main(string[] args)
    {
        List<string> cliente = new List<string>();
        int validacao;
        int escolhaAdicional=0;
        int numeroEscolhido=0;
        Console.Clear();

        Console.WriteLine("Insira seu nome:");
        cliente.Add(Console.ReadLine());
        Console.Clear();

        while (true)
        {
            Console.ResetColor();
            Console.WriteLine("Digite o número de acordo com o que deseja:\n\n---------------- CARDÁPIO ----------------\n1 - Hambúrguer\n2 - Hambúrguer de calabresa\n3 - Xtudo\n4 - Dobradão\n5 - Pizza\n6 - Pizza de catupiry\n7 - Bebidas\n8 - Sorvete\n------------------------------------------\n\n----------------- GESTÃO -----------------\n9 - Gestor\n------------------------------------------");
            try{
              numeroEscolhido = int.Parse(Console.ReadLine());
              Console.Clear();
              if ((numeroEscolhido != 1) && (numeroEscolhido !=7) && (numeroEscolhido<8) && (numeroEscolhido>0)){
                Console.WriteLine("Deseja adicional?\nDigite 1 para sim e 2 para não");
                escolhaAdicional = int.Parse(Console.ReadLine());
                Console.Clear();
              }
            }
            catch(FormatException){
              mostrarError();
            }
            if (numeroEscolhido == 1)
            {
                Hamburguer ham = new Hamburguer();
                ham.setNome("Hambúrguer");
                ham.retorno();
            }
            else if (numeroEscolhido == 2)
            {
                HamCalabresa hamCalabresa = new HamCalabresa();
                hamCalabresa.setNome("Hambúrguer Calabresa");
                switch (escolhaAdicional)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Deseja acrescentar qual adicional?\n\nBife\nAlface\nTomate\nPicles\nBatata\nOvo\nCalabresa\nQueijos\nAzeitona\n");
                            string tipo = Console.ReadLine().ToLower();
                            Console.Clear();
                            Console.WriteLine("Quantas unidades->");
                            int qtd = int.Parse(Console.ReadLine());
                            hamCalabresa.setAdicional(tipo, qtd);
                            Console.Clear();
                            Console.WriteLine("Irá querer mais algum adicional?\nDigite 1 para sim e 2 para não");
                            escolhaAdicional = int.Parse(Console.ReadLine());
                        } while (escolhaAdicional == 1);
                        Console.Clear();
                        Console.WriteLine("Gostaria de um acompanhamento gratuito?\nDigite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());

                        if (validacao ==1)  {
                            Console.Clear();
                            hamCalabresa.AcompanhamentoAleatorio = true;
                        }    
                        else{
                            Console.Clear();
                            hamCalabresa.AcompanhamentoAleatorio = false;
                        }
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        hamCalabresa.retorno();

                        cliente.RemoveAt(0);
                        break;

                    case 2:
                        hamCalabresa.AcompanhamentoAleatorio = true;
                        Console.WriteLine("Gostaria de um acompanhamento gratuito?\nDigite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());
                        if (validacao == 1)
                            hamCalabresa.AcompanhamentoAleatorio = true;
                        else
                            hamCalabresa.AcompanhamentoAleatorio = false;
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        hamCalabresa.retorno();

                        cliente.RemoveAt(0);
                        break;
                }
            }
            else if (numeroEscolhido == 3)
            {
                HamXtudo hamXtudo = new HamXtudo();
                hamXtudo.setNome("Xtudo");
                switch (escolhaAdicional)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Deseja acrescentar qual adicional?\n\nBife\nAlface\nTomate\nPicles\nBatata\nOvo\nCalabresa\nQueijos\nAzeitona\n");
                            string tipo = Console.ReadLine().ToLower();
                            Console.Clear();
                            Console.WriteLine("Quantas unidades->");
                            int qtd = int.Parse(Console.ReadLine());
                            hamXtudo.setAdicional(tipo, qtd);
                            Console.Clear();
                            Console.WriteLine("Irá querer mais algum adicional?\nDigite 1 para sim e 2 para não");
                            escolhaAdicional = int.Parse(Console.ReadLine());

                        } while (escolhaAdicional == 1);
                        Console.Clear();
                        Console.WriteLine("Gostaria de um acompanhamento gratuito?\nDigite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());
                        if (validacao == 1)
                            hamXtudo.AcompanhamentoAleatorio = true;
                        else
                            hamXtudo.AcompanhamentoAleatorio = false;
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        hamXtudo.retorno();
                        cliente.RemoveAt(0);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Gostaria de um acompanhamento gratuito?\nDigite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());
                        if (validacao == 1)
                            hamXtudo.AcompanhamentoAleatorio = true;
                        else
                            hamXtudo.AcompanhamentoAleatorio = false;
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        hamXtudo.retorno();
                        cliente.RemoveAt(0);
                        break;
                }

            }
            else if (numeroEscolhido == 4)
            {
                HamDobradao hamDobradao = new HamDobradao();
                hamDobradao.setNome("Dobradão");
                switch (escolhaAdicional)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Deseja acrescentar qual adicional?\n\nBife\nAlface\nTomate\nPicles\nBatata\nOvo\nCalabresa\nQueijos\nAzeitona\n");
                            string tipo = Console.ReadLine().ToLower();
                            Console.Clear();
                            Console.WriteLine("Quantas unidades->");
                            int qtd = int.Parse(Console.ReadLine());
                            Console.Clear();
                            hamDobradao.setAdicional(tipo, qtd);
                            Console.Clear();
                            Console.WriteLine("Irá querer mais algum adicional?\nDigite 1 para sim e 2 para não");
                            escolhaAdicional = int.Parse(Console.ReadLine());

                        } while (escolhaAdicional == 1);
                        Console.Clear();
                        Console.WriteLine("Gostaria de um acompanhamento gratuito?\nDigite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());
                        if (validacao == 1)
                            hamDobradao.AcompanhamentoAleatorio = true;
                        else
                            hamDobradao.AcompanhamentoAleatorio = false;
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        hamDobradao.retorno();
                        cliente.RemoveAt(0);
                        break;
                    case 2:
                      Console.Clear();
                        Console.WriteLine("Gostaria de um acompanhamento gratuito?\nDigite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());
                        if (validacao == 1)
                            hamDobradao.AcompanhamentoAleatorio = true;
                        else
                            hamDobradao.AcompanhamentoAleatorio = false;
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        hamDobradao.retorno();

                        cliente.RemoveAt(0);
                        break;
                }
            }
            else if (numeroEscolhido == 5)
            {
                Pizza pizza = new Pizza();
                pizza.setNome("pizza");
                pizza.retorno();
            }
            else if (numeroEscolhido == 6)
            {
                PizzaCatupiry pizzaCatu = new PizzaCatupiry();
                pizzaCatu.setNome("pizza de catupiry");
                switch (escolhaAdicional)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Deseja acrescentar qual adicional?\n\nBife\nAlface\nTomate\nPicles\nBatata\nOvo\nCalabresa\nQueijos\nAzeitona\n");
                            string tipo = Console.ReadLine().ToLower();
                            Console.Clear();
                            Console.WriteLine("Quantas unidades->");

                            int qtd = int.Parse(Console.ReadLine());
                            pizzaCatu.setAdicional(tipo, qtd);
                            Console.Clear();
                            Console.WriteLine("Irá querer mais algum adicional?\nDigite 1 para sim e 2 para não");
                            escolhaAdicional = int.Parse(Console.ReadLine());
                        } while (escolhaAdicional == 1);
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        pizzaCatu.retorno();

                        cliente.RemoveAt(0);
                        break;
                    case 2:
                    Console.Clear();
                        Console.WriteLine("Gostaria de uma borda recheada?, Digite 1 para sim e 2 para não");
                        validacao = int.Parse(Console.ReadLine());
                        if (validacao == 1)
                            pizzaCatu.BordaRecheada = true;
                        else
                            pizzaCatu.BordaRecheada = false;
                        foreach (string nome in cliente)
                            Console.WriteLine("Cliente => {0}", nome);
                        pizzaCatu.retorno();
                        cliente.RemoveAt(0);
                        break;
                }
            }
            else if(numeroEscolhido==7){
              Bebidas bebida = new Bebidas();
                Console.WriteLine("\nEscolha o tipo de bebida:\nDigite 1 para Refrigerante \nDigite 2 para Suco\nDigite 3 para Refrigerante");
                try{
                  int resposta3 = int.Parse(Console.ReadLine());

                  Console.WriteLine("\nEscolha o tipo de bebida:\nDigite 1 para 300 ml \nDigite 2 para 600 ml\nDigite 3 para 2 litros");
                  int quantidade = int.Parse(Console.ReadLine());
                  bebida.setQuantidade(quantidade);
                  if((quantidade <=3) && (quantidade >=1)){
                    if (resposta3 == 1)
                      bebida.setTipo("Refrigerante");
                    else if(resposta3 == 2)
                      bebida.setTipo("Suco");            
                    else
                      bebida.setTipo("Cerveja");
                    
                    bebida.setNome("Bebida");
                    Console.Clear();
                    bebida.Retorno();
                  }
                  else{
                    mostrarError();
                  }
                }
                catch(FormatException){
                  mostrarError();
                }
            }
            else if (numeroEscolhido==8){
              Sorvete sorvete = new Sorvete();
                Console.WriteLine("\nEscolha o tipo de sorvete:\nDigite 1 para casquinha\nDigite 2 para copinho\nDigite 3 para Milk Shake");
                try{
                  int resposta4 = int.Parse(Console.ReadLine());
                  if((resposta4 <=3) && (resposta4 >=1)){
                    if(resposta4==1)
                      sorvete.setTipo("Casquinha");
                    else if (resposta4==2)
                      sorvete.setTipo("Copo");
                    else
                      sorvete.setTipo("MilkShake");

                    sorvete.setNome("Sorvete");
                    Console.Clear();
                    sorvete.Retorno();
                }
                else{
                  mostrarError();
                }
                }
                catch(FormatException){
                  mostrarError();
              }
            }
            else if (numeroEscolhido == 9)
            {
                Console.WriteLine("Digite a senha para entrar:");
                string senha = Console.ReadLine();
                if (senha == "aed2019")
                {
                    Console.Clear();
                    Console.WriteLine("O a taxa de lucratividade do restaurante é {0}%\n", Egestor.Gestor().ToString("F"));

                    if (Egestor.Gestor() > 20.00)
                        Console.WriteLine("A Taxa de lucro está exorbitante\n");
                    else if (Egestor.Gestor() > 0.00)
                        Console.WriteLine("A taxa de lucro está normal talvez seja melhor repensar o negócio\n");
                    else
                        Console.WriteLine("A taxa de lucro está negativa seu negócio gera prejuízo\n");
                }
                else
                    Console.WriteLine("\nSenha incorreta\n");
            }
            else
              mostrarError();

        }
    }
}
