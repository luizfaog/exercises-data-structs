using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int questao;
            Console.WriteLine("Digite o número da questao: ");
            questao = int.Parse(Console.ReadLine());
            
            switch (questao)
            {
                case == 1:
                questao1();
                    break;

                case == 2:
                    questao2();
                    break;

                case == 3:
                    questao3();
                    break;

                case == 4:
                    questao4();
                    break;

                case == 5:
                    questao5();
                    break;

                case == 6:
                    questao6();
                    break;

                case == 7:
                    questao7();
                    break;

                case == 8:
                    questao8();
                    break;

                case == 9:
                    questao9();
                    break;

                case == 10:
                    questao10();
                    break;
  
                
        }
            static void questao1()
            {
                int[] array1 = new int[10];
                for (int i = 0; i <= array1.Length - 1; i++)
                {
                    Console.WriteLine("Digite um número inteiro: ");
                    array1[i] = int.Parse(Console.ReadLine());
                }

                int[] array2 = new int[10];
                for (int j = 0; j <= array2.Length - 1; j++)
                {
                    if (j < 9)
                    {
                        array2[j] = array1[j] * array1[j + 1];

                    }
                    else
                    {
                        array2[j] = array1[j] * 1;
                    }
                    Console.WriteLine(array2[j]);
                    Console.ReadLine();
                }
        }
            static void questao2()
        {
            int[] array1 = new int[5];
            
            for (int i=0; i<= array1.Length - 1; i++)
            {
                Console.WriteLine("Digite um número inteiro qualquer: ");
                array1[i] = int.Parse(Console.ReadLine());
            }

            int[] array2 = new int[5];

            for (int j=4; j<=array2.Length - 1; j--)
            {
                Console.Write(array1[j]);
                Console.ReadLine();
            }
        }
            static void questao3()
            {
            int[,] matriz1 = new int[4, 4];
            
            for (int linhas=0; linhas<=3; linhas++)
            {
                Console.WriteLine($"Escreva os valores da linha {linhas + 1}: ");
                for (int colunas=0; colunas<=3; colunas++)
                {
                    matriz1[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                }
            }
            

            int[,] matriz2 = new int[4, 4];

            for (int linhas = 0; linhas <= 3; linhas++)
            {
                Console.WriteLine($"Escreva o valor da linha {linhas + 1}: ");
                for (int colunas = 0; colunas <= 3; colunas++)
                {
                   
                    matriz2[linhas, colunas] = Convert.ToInt32(Console.ReadLine());
                }
            }
           

            int[,] soma = new int[4, 4];
            Console.WriteLine("A matriz resultante da matriz a e matriz b é: ");
            for(int linhas=0; linhas <= 3; linhas++)
            {
                for(int colunas=0; colunas<=3; colunas++)
                {
                    Console.Write(matriz1[linhas, colunas] + matriz2[linhas, colunas] + "\t");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
            static void questao4()
            {
            double[,] planilha = new double[12, 4];

            for (int mes=0; mes<=11; mes++) 
            { 
                for (int semana=0;semana<=3; semana++)
                {
                    Random gerarNumero = new Random();
                    planilha[mes, semana] = mes + gerarNumero.Next(1,100) * semana + gerarNumero.Next(1, 100);
                    Console.Write(planilha[mes,semana] + "\t"); 
                }
                Console.ReadLine();            
            }
            for (int mes = 0; mes <= 11; mes++)
            {
                double totalDoMes = 0;
                for (int semana = 0; semana <= 3; semana++)
                {
                   totalDoMes = totalDoMes + planilha[mes, semana];
                }
                Console.WriteLine($"Total no mês {mes + 1}: {totalDoMes} ");
                Console.ReadLine();
            }
            for (int mes = 0; mes <= 11; mes++)
            {
                Console.WriteLine("Semanas do mês: " + (mes + 1));
                for (int semana = 0; semana <= 3; semana++)
                {
                    Console.WriteLine($"Total na semana {semana + 1}: {planilha[mes, semana]}");
                }
                Console.ReadLine();
            }
            double totalDoAno = 0;
            for (int mes = 0; mes <= 11; mes++)
            {
               for (int semana = 0; semana <= 3; semana++)
                {
                    totalDoAno = totalDoAno + planilha[mes, semana];
                }
            }
            Console.WriteLine("O valor total adquirido no ano foi: " + totalDoAno);
            Console.ReadLine();


        }
            static void questao5()
        {
            List <string> lista = new List <string> ();
            lista.Add("Branco");
            lista.Add("Vermelho");
            lista.Add("Amarelo");
            lista.Add("Azul");
            lista.Add("Rosa");
            
            foreach (string nomes in lista)
            {
                Console.Write( nomes  );
                
            }
            Console.Write("\n");
            lista.Remove("Branco");
            lista.Remove("Vermelho");
            lista.Remove("Amarelo");
            lista.Add("Branco");
            lista.Add("Vermelho");
            lista.Add("Amarelo");
            foreach (string nomes in lista)
            {
                Console.Write( nomes );
            }

            Console.ReadLine();
        }
        static void questao6()
        {
            int menu = 0;
            List<string> lista = new List<string>();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - Adicionar usuario");
            Console.WriteLine("2 - Remover usuário");
            Console.WriteLine("3 - Substituir usuário ");
            Console.WriteLine("4 - Limpar a lista ");
            menu = int.Parse(Console.ReadLine());
            string usuarios;
            int quantUsuarios = 0;

            if (menu == 1)
            
            {
                Console.WriteLine("informe a quantidade de usuários que deseja adicionar");
                quantUsuarios = int.Parse(Console.ReadLine());
                for (int i=0; i< quantUsuarios; i++)
                {
                    Console.WriteLine("informe o nome do usuário: ");
                    usuarios = Console.ReadLine();
                    lista.Add(usuarios);
                }
                foreach(string nomes in lista)
                {
                    Console.WriteLine(nomes + " ");
                    }
                Console.ReadLine();
            }
            else if(menu == 2)
            {
                Console.WriteLine("informe o usuário que quer remover: ");
                usuarios = Console.ReadLine();
                lista.Remove(usuarios);
               
            }
            foreach (string nomes in lista)
            {
                Console.WriteLine(nomes + " ");
            }
            Console.ReadLine();


        }
        static void questao7()
        {
            Stack<string> minhaPilha = new Stack<string>();
            minhaPilha.Push("Prato1");
            minhaPilha.Push("Prato2");
            minhaPilha.Push("Prato3");
            minhaPilha.Push("Prato4");
            minhaPilha.Push("Prato5");
            minhaPilha.Pop();
            minhaPilha.Pop();
            minhaPilha.Push("Prato6");
            foreach (string pratos in minhaPilha)
            {
                Console.WriteLine(pratos );
            }
            Console.ReadLine();
        }
        static void questao8()
        {
            Stack<int> pilhaA = new Stack<int>();
            Stack<int> pilhaB = new Stack<int>();
            Stack<int> pilhaC = new Stack<int>();

            pilhaA.Push(3);
            pilhaA.Push(2);
            pilhaA.Push(1);

            pilhaC.Push(pilhaA.Pop());
            pilhaB.Push(pilhaA.Pop());
            pilhaC.Push(pilhaA.Pop());
            pilhaA.Push(pilhaB.Pop());
            pilhaB.Push(pilhaC.Pop());
            pilhaB.Push(pilhaA.Pop());
            pilhaB.Push(pilhaC.Pop());

            Console.WriteLine("Pilha B: ");
            foreach (int x in pilhaB)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
        static void questao9()
        {
            Queue<string> minhaFila = new Queue<string>();
            minhaFila.Enqueue("pessoa1");
            minhaFila.Enqueue("pessoa2");
            minhaFila.Enqueue("pessoa3");
            minhaFila.Enqueue("pessoa4");
            minhaFila.Enqueue("pessoa5");
            minhaFila.Dequeue();
            minhaFila.Dequeue();
            minhaFila.Enqueue("pessoa6");
            foreach(string pessoas in minhaFila)
            {
                Console.WriteLine(pessoas);
            }
            Console.ReadLine();
        }
        static void questao10()
        {
            Queue<int> minhaFila1 = new Queue<int>();
            minhaFila1.Enqueue(1);
            minhaFila1.Enqueue(2);
            minhaFila1.Enqueue(3);
            minhaFila1.Enqueue(4);
            Queue<int> minhaFila2 = new Queue<int>();
            minhaFila2.Enqueue(5);
            minhaFila2.Enqueue(6);
            minhaFila2.Enqueue(7);
            minhaFila2.Enqueue(8);

            foreach(int fila1 in minhaFila1)
            {
                Console.Write(fila1);
            }
            Console.Write(" ");
            foreach(int fila2 in minhaFila2)
            {
                Console.Write(fila2);
            }
            Console.ReadLine();

            Console.WriteLine("Deseja trocar os elementos de cada fila pelos elementos da fila oposta? (sim ou nao)");
            string inverter = Console.ReadLine();
            if (inverter == "sim")
            {
                minhaFila1.Dequeue();
                minhaFila1.Dequeue();
                minhaFila1.Dequeue();
                minhaFila1.Dequeue();
                minhaFila2.Dequeue();
                minhaFila2.Dequeue();
                minhaFila2.Dequeue();
                minhaFila2.Dequeue();
                minhaFila1.Enqueue(5);
                minhaFila1.Enqueue(6);
                minhaFila1.Enqueue(7);
                minhaFila1.Enqueue(8);
                minhaFila2.Enqueue(1);
                minhaFila2.Enqueue(2);
                minhaFila2.Enqueue(3);
                minhaFila2.Enqueue(4);
                foreach(int fila1 in minhaFila1)
            {
                    Console.Write(fila1);
                }
                Console.Write(" ");
                foreach (int fila2 in minhaFila2)
                {
                    Console.Write(fila2);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aperte enter para fechar o programa");
            }
            Console.ReadKey();

        }
        
    }
    
}
