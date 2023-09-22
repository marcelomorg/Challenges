using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("(00)1111-1111", "Iphone12", "IMEI1232123", 6);
Nokia nokia = new Nokia("(00)1111-2222", "Nokia 5", "IMEI4234234552", 4);
List<Smartphone> smartphones = new List<Smartphone>();
smartphones.Add(iphone);
smartphones.Add(nokia);

try 
{
    foreach (Smartphone smartphone in smartphones)
    {
        Console.WriteLine("\nTESTE DO SMARTPHONE: {0}.", smartphone.Modelo);
        smartphone.InstalarAplicativo("TestPhone");
        Console.WriteLine($"Numero: {smartphone.Numero}");
        smartphone.Ligar();
        smartphone.ReceberLigacao();
        Console.WriteLine($"IMEI: {smartphone.IMEI}\nMemória Ram: {smartphone.Memoria}");
        Console.WriteLine("Teste do smartphone {0} foi concluído com sucesso.\n", smartphone.Modelo);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Falha ao executar o Teste. ERRO: {ex.Message}");
}