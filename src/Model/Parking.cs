using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace src.Model;

public class Parking
{
    public Parking(){}

    private List<string> veiculos = new List<string>();

    public void GetVeiculos()
    {
        if(veiculos.Count == 0)
        {
           Console.WriteLine("Nenhum Veiculo cadastrado");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Veiculos Cadastrados:");
            int contador = 0;
            foreach (string veiculo in veiculos)
            {  
                Console.WriteLine($"\t{contador} placa: {veiculo}");
                contador++;
            }

        }
    }

    public void SetVeiculo()
    {
        Console.WriteLine("Informe sua placa");
        string placa = Console.ReadLine();
        bool result = ValidaPlaca(placa);

        if (!result)
        {
            Console.WriteLine("Placa invalida digite novamente conforme o exemplo: AAA1234");
        }
        else
        {
            veiculos.Add(placa);
        }
    }

    public void RmVeiculos()
    {
        Console.WriteLine("Informe a ser removida placa: ");
        string placa = Console.ReadLine();
        veiculos.Remove(placa);

    }

    public bool ValidaPlaca(string placa)
    {
        Regex regex = new Regex(@"^[A-Za-z]{3}[0-9][0-9A-Z][0-9]{2}$");
        
        if(regex.IsMatch(placa))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
    }


}
