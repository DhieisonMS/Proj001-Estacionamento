using src.Model;

public class Program
{
    static void Main (string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello, welcome");
            Console.WriteLine("Select a option:\n");
            Console.WriteLine("\t 1 - Register Vehicle");
            Console.WriteLine("\t 2 - List Vehicle");
            Console.WriteLine("\t 3 - Remove Vehicle");
            
            Parking teste = new Parking();

            teste._veiculos.Add("teste");

            switch (Console.ReadLine())
            {
                case "1":
                    teste.SetVeiculo();
                    
                    break;
                case "2":
                    teste.GetVeiculos();
                    
                    break;
                case "3":
                    Console.WriteLine("3");
                    break;
                default:
                    Console.WriteLine("opção invalida");
                    break;
            }   
        }
        
        
    }
}