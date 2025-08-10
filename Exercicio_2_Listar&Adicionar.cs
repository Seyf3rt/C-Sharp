using System;

public class Programa
{
    public static void Main(string[] args)
    {
        string especieAnimal = "";
        string idAnimal = "";
        string idadeAnimal = "";
        string descricaoFisicaAnimal = "";
        string descricaoPersonalidadeAnimal = "";
        string apelidoAnimal = "";

        int maxAnimais = 8;
        string? resultadoLeitura;
        string selecaoMenu = "";

        string[,] nossosAnimais = new string[maxAnimais, 6];

        for (int i = 0; i < maxAnimais; i++)
        {
            switch (i)
            {
                case 0:
                    especieAnimal = "cachorro";
                    idAnimal = "c1";
                    idadeAnimal = "2";
                    descricaoFisicaAnimal = "fêmea golden retriever de tamanho médio, creme, pesando cerca de 29 quilos. adestrada.";
                    descricaoPersonalidadeAnimal = "adora que cocem a barriga e gosta de perseguir o próprio rabo. dá muitos beijos.";
                    apelidoAnimal = "lola";
                    break;

                case 1:
                    especieAnimal = "cachorro";
                    idAnimal = "c2";
                    idadeAnimal = "9";
                    descricaoFisicaAnimal = "macho golden retriever grande, marrom-avermelhado, pesando cerca de 38 quilos. adestrado.";
                    descricaoPersonalidadeAnimal = "adora que cocem as orelhas quando te encontra na porta, ou a qualquer momento! gosta de se apoiar e dar abraços.";
                    apelidoAnimal = "loki";
                    break;

                case 2:
                    especieAnimal = "gato";
                    idAnimal = "g3";
                    idadeAnimal = "1";
                    descricaoFisicaAnimal = "fêmea pequena e branca pesando cerca de 3,5 quilos. usa caixa de areia.";
                    descricaoPersonalidadeAnimal = "amigável";
                    apelidoAnimal = "puss";
                    break;

                case 3:
                    especieAnimal = "gato";
                    idAnimal = "g4";
                    idadeAnimal = "?";
                    descricaoFisicaAnimal = "";
                    descricaoPersonalidadeAnimal = "";
                    apelidoAnimal = "";
                    break;

                default:
                    especieAnimal = "";
                    idAnimal = "";
                    idadeAnimal = "";
                    descricaoFisicaAnimal = "";
                    descricaoPersonalidadeAnimal = "";
                    apelidoAnimal = "";
                    break;
            }

            nossosAnimais[i, 0] = "ID #: " + idAnimal;
            nossosAnimais[i, 1] = "Espécie: " + especieAnimal;
            nossosAnimais[i, 2] = "Idade: " + idadeAnimal;
            nossosAnimais[i, 3] = "Apelido: " + apelidoAnimal;
            nossosAnimais[i, 4] = "Descrição física: " + descricaoFisicaAnimal;
            nossosAnimais[i, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;
        }

        do
        {
            Console.Clear();

            Console.WriteLine("Bem-vindo(a) ao aplicativo PetFriends. As opções do menu principal são:");
            Console.WriteLine(" 1. Listar todas as informações dos nossos animais");
            Console.WriteLine(" 2. Adicionar um novo amigo animal ao array nossosAnimais");
            Console.WriteLine();
            Console.WriteLine("Digite o número da sua seleção (ou digite Sair para sair do programa)");

            resultadoLeitura = Console.ReadLine();
            if (resultadoLeitura != null)
            {
                selecaoMenu = resultadoLeitura.ToLower();
            }

            switch (selecaoMenu)
            {
                case "1":
                    for (int i = 0; i < maxAnimais; i++)
                    {
                        if (nossosAnimais[i, 0] != "ID #: ")
                        {
                            Console.WriteLine();
                            for (int j = 0; j < 6; j++)
                            {
                                Console.WriteLine(nossosAnimais[i, j]);
                            }
                        }
                    }
                    Console.WriteLine("\n\rPressione a tecla Enter para continuar");
                    resultadoLeitura = Console.ReadLine();
                    break;

                case "2":
                    string outroAnimal = "y";
                    int contadorAnimais = 0;
                    for (int i = 0; i < maxAnimais; i++)
                    {
                        if (nossosAnimais[i, 0] != "ID #: ")
                        {
                            contadorAnimais += 1;
                        }
                    }

                    if (contadorAnimais < maxAnimais)
                    {
                        Console.WriteLine($"Atualmente, temos {contadorAnimais} animais que precisam de um lar. Podemos gerenciar mais {(maxAnimais - contadorAnimais)}.");
                    }

                    while (outroAnimal == "y" && contadorAnimais < maxAnimais)
                    {
                        bool entradaValida = false;

                        do
                        {
                            Console.WriteLine("\n\rDigite 'cachorro' ou 'gato' para iniciar uma nova entrada");
                            resultadoLeitura = Console.ReadLine();
                            if (resultadoLeitura != null)
                            {
                                especieAnimal = resultadoLeitura.ToLower();
                                if (especieAnimal != "cachorro" && especieAnimal != "gato")
                                {
                                    entradaValida = false;
                                }
                                else
                                {
                                    entradaValida = true;
                                }
                            }
                        } while (entradaValida == false);

                        idAnimal = especieAnimal.Substring(0, 1) + (contadorAnimais + 1).ToString();

                        do
                        {
                            int idadePet;
                            Console.WriteLine("Digite a idade do animal ou digite ? se for desconhecida");
                            resultadoLeitura = Console.ReadLine();
                            if (resultadoLeitura != null)
                            {
                                idadeAnimal = resultadoLeitura;
                                if (idadeAnimal != "?")
                                {
                                    entradaValida = int.TryParse(idadeAnimal, out idadePet);
                                }
                                else
                                {
                                    entradaValida = true;
                                }
                            }
                        } while (entradaValida == false);

                        do
                        {
                            Console.WriteLine("Digite uma descrição física do animal (tamanho, cor, sexo, peso, adestrado)");
                            resultadoLeitura = Console.ReadLine();
                            if (resultadoLeitura != null)
                            {
                                descricaoFisicaAnimal = resultadoLeitura.ToLower();
                                if (descricaoFisicaAnimal == "")
                                {
                                    descricaoFisicaAnimal = "a ser definido";
                                }
                            }
                        } while (descricaoFisicaAnimal == "");

                        do
                        {
                            Console.WriteLine("Digite uma descrição da personalidade do animal (gostos ou aversões, truques, nível de energia)");
                            resultadoLeitura = Console.ReadLine();
                            if (resultadoLeitura != null)
                            {
                                descricaoPersonalidadeAnimal = resultadoLeitura.ToLower();
                                if (descricaoPersonalidadeAnimal == "")
                                {
                                    descricaoPersonalidadeAnimal = "a ser definido";
                                }
                            }
                        } while (descricaoPersonalidadeAnimal == "");

                        do
                        {
                            Console.WriteLine("Digite um apelido para o animal");
                            resultadoLeitura = Console.ReadLine();
                            if (resultadoLeitura != null)
                            {
                                apelidoAnimal = resultadoLeitura.ToLower();
                                if (apelidoAnimal == "")
                                {
                                    apelidoAnimal = "a ser definido";
                                }
                            }
                        } while (apelidoAnimal == "");

                        nossosAnimais[contadorAnimais, 0] = "ID #: " + idAnimal;
                        nossosAnimais[contadorAnimais, 1] = "Espécie: " + especieAnimal;
                        nossosAnimais[contadorAnimais, 2] = "Idade: " + idadeAnimal;
                        nossosAnimais[contadorAnimais, 3] = "Apelido: " + apelidoAnimal;
                        nossosAnimais[contadorAnimais, 4] = "Descrição física: " + descricaoFisicaAnimal;
                        nossosAnimais[contadorAnimais, 5] = "Personalidade: " + descricaoPersonalidadeAnimal;

                        contadorAnimais = contadorAnimais + 1;

                        if (contadorAnimais < maxAnimais)
                        {
                            Console.WriteLine("Você quer inserir informações para outro animal (s/n)");
                            do
                            {
                                resultadoLeitura = Console.ReadLine();
                                if (resultadoLeitura != null)
                                {
                                    outroAnimal = resultadoLeitura.ToLower();
                                }
                            } while (outroAnimal != "s" && outroAnimal != "n");
                        }
                    }

                    if (contadorAnimais >= maxAnimais)
                    {
                        Console.WriteLine("Atingimos nosso limite de animais que podemos gerenciar.");
                        Console.WriteLine("Pressione a tecla Enter para continuar.");
                        resultadoLeitura = Console.ReadLine();
                    }
                    break;
            }
        } while (selecaoMenu != "sair");
    }
}