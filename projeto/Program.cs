using System;
using System.Collections.Generic;
using System.Data.Common;

class Program {

    static int AdicionarContato(List<object> agenda, int id) {

        Console.WriteLine("Digite um nome do contato: ");
        string nomeTemp = Console.ReadLine();

        Console.WriteLine("Digite o numero do contato: ");
        double numeroTemp = Convert.ToDouble(Console.ReadLine());

        id++;

        var contato = new {nomeTemp, numeroTemp, id};
        agenda.Add(contato);

        Console.WriteLine("Contato criado com sucesso! O Id dele é: " +id);
        return id;
    }

    static void VisualizarContato(List<object> agenda, int id) {
        Console.WriteLine("Digite o id do contato a ser visualizado: ");
        int idTemp = int.Parse(Console.ReadLine());

        if (id== idTemp){ //seguinte diogao, aqui so compara com o ultimo item da lista, para procurar em tods tem que percorrer ela, vai ser osso

        }
        else Console.WriteLine("ID não encontrado");
    }
    static void ExcluirContato(List<object> agenda, int id) {
        Console.WriteLine("Digite o id do contato a ser excluido: ");
        int idTemp = int.Parse(Console.ReadLine());
    }
    static void Main() 
    {
        int n1 = 1;
        int id = 0;
        List<object> Agenda = new List<object>();
        while(n1!=99)
        {
            Console.WriteLine("\nDigite o número para acessar a opção: \n 1 - Adicionar contato \n 3 - Visualizar contato \n 4 - Excluir contato \n 99 - Sair");
            Console.Write("> ");
            n1 = int.Parse(Console.ReadLine());

            if(n1==1) {AdicionarContato(Agenda, id); id++;}
            else if(n1==3) VisualizarContato(Agenda, id);
            else if(n1==4) ExcluirContato(Agenda, id);
            else if(n1==99) Console.WriteLine("Fim do programa");
            else Console.WriteLine("Opção inexiste, tente novamente");
        }
    }
}    
