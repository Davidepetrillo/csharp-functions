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

    for(int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;
}


// ---------- Funzione somma elementi dell'array ----------


int SommaElementiArray(int[] array)
{
    int somma = 0;
    for(int i = 0; i < array.Length; i++)
    {
        somma = somma + array[i];
    }
    return somma;
}




// ---------- Programma ----------

int[] arrayDiNumeri = {2, 6, 7, 5, 3, 9};

StampaArray(arrayDiNumeri);

int numeroTest = 3;
int numeroAlQuadrato = Quadrato(numeroTest);
Console.WriteLine(numeroAlQuadrato);

int[] arrayElevatoAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);

StampaArray(arrayElevatoAlQuadrato);

StampaArray(arrayDiNumeri);

int sommaElementiDellArray = SommaElementiArray(arrayDiNumeri);
Console.WriteLine($"La somma degli elementi del'array è {sommaElementiDellArray}");

int sommaElementiDellArrayAlQuadrato = SommaElementiArray(arrayElevatoAlQuadrato);
Console.WriteLine($"La somma degli elementi del'array al quadrato è {sommaElementiDellArrayAlQuadrato}");

