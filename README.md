# longSlice
## Obiettivo
Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.

Ad esempio:

data in ingresso la stringa "1027839564",

il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)

e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).

Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

## Codice

```C#
public static class LargestSeriesProduct

{
    public static long GetLargestProduct(string digits, int span)
{
    if (span == 0)
     {
        return 1;
    }
    if (span > digits.Length || span < 0)
    {
            throw new ArgumentException();
        }
        
        long maxProduct = 0;
        for (int i = 0; i <= digits.Length - span; i++)
        {
            long product = 1;
            for (int j = i; j < i + span; j++)
            {
                product *= digits[j] - '0';
            }
            if (product > maxProduct)
            {
                maxProduct = product;
            }
        }
        return maxProduct;
    }
}
```

Il codice inizia con una classe statica denominata "LargestSeriesProduct" che fornisce un metodo statico "GetLargestProduct" per trovare il prodotto più grande di una serie di numeri in una stringa di cifre.
Il metodo "GetLargestProduct" prende due argomenti: una stringa di cifre e la lunghezza della serie di numeri che si desidera moltiplicare.
Se la lunghezza della serie di numeri passata è 0, il metodo restituisce 1.
Se la lunghezza della serie di numeri supera la lunghezza della stringa di cifre o è negativa, il metodo lancia un'eccezione ArgumentException.
Il metodo utilizza due cicli for annidati per calcolare il prodotto più grande di una serie di numeri. 
Il ciclo esterno scorre lungo la stringa di cifre dall'inizio fino alla fine della serie meno la lunghezza della serie, il che assicura che la serie di numeri scelta rimanga all'interno della stringa.
Il ciclo interno esegue la moltiplicazione dei numeri nella serie selezionata, utilizzando l'operatore di moltiplicazione "*" e la conversione di carattere in intero "digits[j] - '0'".
Il prodotto viene memorizzato in una variabile locale "product" e confrontato con il massimo prodotto trovato finora, memorizzato nella variabile "maxProduct". 
Se il prodotto corrente è maggiore del massimo prodotto trovato finora, la variabile "maxProduct" viene aggiornata con il nuovo prodotto corrente.
Alla fine del ciclo, il metodo restituisce il massimo prodotto trovato.
