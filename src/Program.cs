using src.Model;

public class Program
{
    static void Main (string[] args)
    {
        Parking teste = new Parking();
        bool menu = true;
        while (menu)
        {
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Hello, welcome");
            Console.WriteLine("Select a option:\n");
            Console.WriteLine("\t 1 - Register Vehicle");
            Console.WriteLine("\t 2 - List Vehicle");
            Console.WriteLine("\t 3 - Remove Vehicle");
            Console.WriteLine("\t 4 - Exit");
            
            switch (Console.ReadLine())
            {
                case "1":
                    teste.SetVeiculo();
                    break;
                case "2":
                    teste.GetVeiculos();
                    break;
                case "3":
                    teste.RmVeiculos();
                    break;
                case "4":
                    Console.WriteLine("Finalizando Acesso");
                    menu = false;
                    break;
                default:
                    Console.WriteLine("opção invalida");               
                    break;
            }   
        }    
    }
}