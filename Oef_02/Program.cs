using Oef_02;

List<Product> producten = new List<Product>();
string filePath = "producten.json";

LoadProductsFromFile();

bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("1. Toon Producten\n2. Voeg Product Toe\n3. Verwijder Product\n4. Afsluiten");
    Console.Write("Kies een optie: ");
    string keuze = Console.ReadLine();

    switch (keuze)
    {
        case "1":
            ToonProducten();
            break;
        case "2":
            VoegProductToe();
            break;
        case "3":
            VerwijderProduct();
            break;
        case "4":
            isRunning = false;
            break;
        default:
            Console.WriteLine("Ongeldige keuze. Probeer opnieuw.");
            break;
    }
}

// Sla de productlijst op naar het JSON-bestand bij het afsluiten
SaveProductsToFile();

void LoadProductsFromFile()
{
    // TODO: Implementeer de logica om producten te laden van een JSON-bestand
}

void SaveProductsToFile()
{
    // TODO: Implementeer de logica om producten op te slaan in een JSON-bestand
}

void ToonProducten()
{
    // TODO: Implementeer de logica om producten te tonen
}

void VoegProductToe()
{
    // TODO: Implementeer de logica om een product toe te voegen
}

void VerwijderProduct()
{
    // TODO: Implementeer de logica om een product te verwijderen
}
