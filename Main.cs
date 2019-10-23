using System;

class MainClass {
  public static void Main (string[] args) {
    int escolha = int.Parse(Console.ReadLine());
  switch (escolha)
  case 1:
    Console.WriteLine ("===========================================================              \n                  Olá, seja bem vindo !!! \n\nPrimeiramente, escolha o seu pedido:\n===========================================================\nDigite 1 para Hambúrguer\nDigite 2 para Pizza\nDigite 3 para Refrigerante\nDigite 4 para Sorvete");

    int pedido = int.Parse(Console.ReadLine());

    switch (pedido)
      {
        case 1:
          Console.WriteLine("\nIrá querer algum adicional?\nDigite 1 para Sim e 2 para não");
          int resposta = int.Parse(Console.ReadLine());
          if (resposta == 1){
            // Nessa parte irá escolher os ingredientes adicionais, mudando com o set
            Console.WriteLine("\nOk");
          }
          else{
            Hamburguer ham = new Hamburguer();
            Console.WriteLine (ham.getPreco());
            ham.SetNome("Hamburguer");

          }
          break;

        case 2:
          Console.WriteLine("\nEscolha o tamanho:\nDigite 1 para 6 pedaços\nDigite 2 para 8 pedaços\nDigite 3 para 10 pedaços");
          int resposta2 = int.Parse(Console.ReadLine());
          // Nessa parte irá mudar o preço de acordo com o tamanho
          if (resposta2 == 1){
            Console.WriteLine("Preço menor");
          }
          else if(resposta2 == 2){
            Console.WriteLine("Preço médio");
          }

          else{
            Console.WriteLine("Preço maior");
          }
          break;

        case 3:
          Console.WriteLine("\nEscolha o tamanho:\nDigite 1 para 300 ml \nDigite 2 para 600 ml\nDigite 3 para 2 litros");

          int resposta3 = int.Parse(Console.ReadLine());

          if (resposta3 == 1){
            Console.WriteLine("Preço menor do refrigerante");
          }
          else if(resposta3 == 2){
            Console.WriteLine("Preço médio do refrigerante");
          }

          else{
            Console.WriteLine("Preço maior do refrigerante");
          }
          break;

        case 4:
          Console.WriteLine("\nEscolha o tipo de sorvete:\nDigite 1 para casquinha\nDigite 2 para copinho\nDigite 3 para Milk Shake");

          break;
    }
    

    Ler lendo = new Ler();
    lendo.LerTxt1();
    lendo.LerTxt2();

case 2:

   echo"isso";

  }
}