using System;
using System.Text.RegularExpressions;

namespace src.Model;

public class Parking
{
    public Parking(){}

    public List<string> _veiculos = new List<string>();

    public void GetVeiculos()
    {
        
        if(_veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum Veiculo cadastrado");
        }
        else
        {
            foreach (var countveiculos in _veiculos)
            {  
                Console.WriteLine("Veiculos Cadastrados:");
                Console.WriteLine($"\t{countveiculos}");
            }
        }
        
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
            _veiculos.Add(placa);
            Console.WriteLine($"Placa cadastrada{placa}");
           
            
        }
    }
}
