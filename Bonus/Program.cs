// ---------- Funzioni ----------




// ---------- Funzione stampaArray ----------

void StampaArray(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}


// ---------- Funzione Quadrato ----------

int Quadrato(int numero)
{
    int quadrato = numero * numero;
    return quadrato;
}



// ---------- Funzione eleva al quadrato l'array ----------


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;
}


// ---------- Funzione somma elementi dell'array ----------


int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}


// ---------- Programma ----------

string richiestaUtente = Console.ReadLine();
int conversioneInteroRichiestaUtente = int.Parse(richiestaUtente);

int[] arrayVuoto = new int[conversioneInteroRichiestaUtente];


    for (int i = 0; i < conversioneInteroRichiestaUtente; i++)
    {
        Console.Write("Inserisci un numero intero a piacere: ");
        string elementiSceltiDallUtente = Console.ReadLine();
        int conversioneElementiSceltiDallUtente = int.Parse(elementiSceltiDallUtente);
        arrayVuoto[i] = conversioneElementiSceltiDallUtente; 
    }

StampaArray(arrayVuoto);

int[] arrayElevatoAlQuadrato = ElevaArrayAlQuadrato(arrayVuoto);

StampaArray(arrayElevatoAlQuadrato);

StampaArray(arrayVuoto);

int sommaElementiDellArray = SommaElementiArray(arrayVuoto);
Console.WriteLine($"La somma degli elementi del'array è {sommaElementiDellArray}");

int sommaElementiDellArrayAlQuadrato = SommaElementiArray(arrayElevatoAlQuadrato);
Console.WriteLine($"La somma degli elementi del'array al quadrato è {sommaElementiDellArrayAlQuadrato}");

