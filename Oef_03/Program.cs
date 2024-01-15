using Oef_03;

GameConfig gameConfig = new GameConfig();
string configPath = "gameConfig.json";

LoadConfig();

bool running = true;
while (running)
{
    Console.WriteLine("\nGame Configuratie Menu:");
    Console.WriteLine("1. Toon Huidige Configuratie");
    Console.WriteLine("2. Wijzig Configuratie");
    Console.WriteLine("3. Sla Configuratie Op");
    Console.WriteLine("4. Afsluiten");
    Console.Write("Kies een optie: ");
    string keuze = Console.ReadLine();

    switch (keuze)
    {
        case "1":
            ToonConfiguratie();
            break;
        case "2":
            WijzigConfiguratie();
            break;
        case "3":
            SlaConfiguratieOp();
            break;
        case "4":
            running = false;
            break;
        default:
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            break;
    }
}
    

void LoadConfig()
{
    // TODO: als er al een configuratie bestand bestaat, dan deserialiseer
    // je dat naar gameConfig.
}

void ToonConfiguratie()
{
    // TODO: Serialiseer het GameConfig object, maar sla het niet op.
    // In plaats daarvan toon je het op het scherm
}

void WijzigConfiguratie()
{
    // TODO: Implementeer logica om verschillende delen van de configuratie te wijzigen
}

void SlaConfiguratieOp()
{
    // TODO: Serialiseer de configuratie en sla die op.
    Console.WriteLine("Configuratie opgeslagen.");
}