using System;
using System.Threading;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    List<string> cliente = new List<string>();


    Console.Clear();

    bool flag = true;
    int n = 0;
    while(flag){
      Console.WriteLine ("\n============================\n1 = funcionario | 2 = Gestor\n============================");

      int escolha = int.Parse(Console.ReadLine());
      Console.Clear();

      if (escolha == 1){
        Console.WriteLine("coloque o seu nome");
        cliente.Add(Console.ReadLine());
        Console.Clear();

        Console.WriteLine ("===========================================================              \n                  Olá, seja bem vindo !!! \n\nPrimeiramente, escolha o seu pedido:\n===========================================================\nDigite 1 para Hambúrguer\nDigite 2 para Pizza\nDigite 3 para Bebidas\nDigite 4 para Sorvete");
        int pedido = int.Parse(Console.ReadLine());
        switch (pedido)
        {
          case 1:
          Hamburguer ham = new Hamburguer();
            Console.WriteLine("\nIrá querer algum adicional?\nDigite 1 para Sim e 2 para não");
            int resposta = int.Parse(Console.ReadLine());
            if (resposta == 1){
              Console.WriteLine("Irá querer colocar quantos hamburgueres no seu lanche?");
              int hamburguer = int.Parse(Console.ReadLine());
              Console.WriteLine("Irá querer colocar quantos salada no seu lanche?");
              int salada = int.Parse(Console.ReadLine());
              Console.WriteLine("Irá querer colocar quantos ovos no seu lanche?");
              int ovo = int.Parse(Console.ReadLine());

              // Nessa parte irá escolher os ingredientes adicionais, mudando com o set
              ham.setAdicional(salada, hamburguer, ovo);
              ham.setNome("Hambúrguer");
              Console.Clear();
              foreach(string nome in cliente)
                Console.WriteLine("Cliente => {0}",nome);
              ham.Retorno();
            }
            else{
              ham.setNome("Hambúrguer");
              Console.Clear();
              foreach(string nome in cliente)
                Console.WriteLine("Cliente => {0}",nome);
              ham.Retorno();
            }
            cliente.RemoveAt(0);
            break;

          case 2:
            Pizza pizza = new Pizza();
            Console.WriteLine("\nEscolha o tamanho:\nDigite 1 para 6 pedaços\nDigite 2 para 8 pedaços\nDigite 3 para 10 pedaços");
            int resposta2 = int.Parse(Console.ReadLine());
            // Nessa parte irá mudar o preço de acordo com o tamanho

            if (resposta2 == 1)
              pizza.setTamanho(6);
            else if(resposta2 == 2)
              pizza.setTamanho(8);
            else
              pizza.setTamanho(10);

            Console.WriteLine("\nIrá querer algum adicional?\nDigite 1 para Sim e 2 para não");

            int adicionalPizza = int.Parse(Console.ReadLine());
            if (adicionalPizza == 1){
              Console.WriteLine("Irá querer mais mussarela?, Digite 1 para Sim e 2 para não");
              int mussarela = int.Parse(Console.ReadLine());
              if (mussarela==1)
                mussarela = 5;
              Console.WriteLine("Irá querer mais azeitona?, Digite 1 para Sim e 2 para não");
              int azeitona = int.Parse(Console.ReadLine());
              if (azeitona==1)
                azeitona = 2;

              pizza.setAdicional(mussarela, azeitona);
              pizza.setNome("Pizza");
              Console.Clear();
              foreach(string nome in cliente)
                Console.WriteLine("Cliente => {0}",nome);
              pizza.Retorno();
            }
            else{
              pizza.setNome("Pizza");
              Console.Clear();
              foreach(string nome in cliente)
                Console.WriteLine("Cliente => {0}",nome);
              pizza.Retorno();
            }
            cliente.RemoveAt(0);

            break;

            case 3:
              Bebidas bebida = new Bebidas();
              Console.WriteLine("\nEscolha o tipo de bebida:\nDigite 1 para Refrigerante \nDigite 2 para Suco\nDigite 3 para Refrigerante");

              int resposta3 = int.Parse(Console.ReadLine());

              Console.WriteLine("\nEscolha o tipo de bebida:\nDigite 1 para 300 ml \nDigite 2 para 600 ml\nDigite 3 para 2 litros");
              int quantidade = int.Parse(Console.ReadLine());
              bebida.setQuantidade(quantidade);

              if (resposta3 == 1)
                bebida.setTipo("Refrigerante");
              else if(resposta3 == 2)
                bebida.setTipo("Suco");
              else
                bebida.setTipo("Cerveja");

              bebida.setNome("Bebida");
              Console.Clear();
              foreach(string nome in cliente)
                Console.WriteLine("Cliente => {0}",nome);
              bebida.Retorno();

              cliente.RemoveAt(0);

              break;

            case 4:
              Sorvete sorvete = new Sorvete();
              Console.WriteLine("\nEscolha o tipo de sorvete:\nDigite 1 para casquinha\nDigite 2 para copinho\nDigite 3 para Milk Shake");

              int resposta4 = int.Parse(Console.ReadLine());

              if(resposta4==1)
                sorvete.setTipo("Casquinha");
              else if (resposta4==2)
                sorvete.setTipo("Copo");
              else
                sorvete.setTipo("MilkShake");

              sorvete.setNome("Sorvete");
              Console.Clear();
              foreach(string nome in cliente)
                Console.WriteLine("Cliente => {0}",nome);
              sorvete.Retorno();

              cliente.RemoveAt(0);
              break;

        }
      }

      else if(escolha == 2){
        Console.WriteLine("Digite a senha para entrar:");
        string senha = Console.ReadLine();
        if (senha == "aed2019"){
          Console.Clear();
          Console.WriteLine("O a taxa de lucratividade do restaurante é {0}%",Egestor.Gestor().ToString("F"));

          if(Egestor.Gestor() > 20.00)
            Console.WriteLine("A Taxa de lucro está exorbitante");
          else if (Egestor.Gestor() > 0.00)
            Console.WriteLine("A taxa de lucro está normal talvez seja melhor repensar o negócio");
          else
            Console.WriteLine("A taxa de lucro está negativa seu negócio gera prejuízo");
        }
        else
          Console.WriteLine("\nSenha incorreta");
      }
      else
        flag= false;
    }
  }
}
