// See https://aka.ms/new-console-template for more information
class Program{
    static void Main()
    {
        int[] matriz = RandomArray(10);
        PrintMatriz(matriz);
        int minimo = CalcMinimo(matriz);
        int maximo = CalcMaximo(matriz);
        int suma = CalcSuma(matriz);

        Console.WriteLine($"Valor minimo : {minimo}");
        Console.WriteLine($"Valor maximo : {maximo}");
        Console.WriteLine($"Valor Suma : {suma}");

        //---------------------------------------------------

        string resultado = TossCoin();
        Console.WriteLine(resultado);

        // ------------------------------------------------

        List<string> nombres = Nombres();

        Console.WriteLine("Nombres con más de 5 caracteres:");
        PrintLista(nombres);

    }


    static int[] RandomArray(int longitud){
        int[] matriz = new int[longitud];
        Random rand = new Random();

        for(int i = 0; i < longitud; i++){
            matriz[i] = rand.Next(5, 26);
        }
        return matriz;
    }

    static void PrintMatriz(int[] matriz){
        Console.WriteLine("Matriz de valores");
        foreach(int valor in matriz){
            Console.WriteLine(valor + " ");
        }
        Console.WriteLine();
    }

    static int CalcMinimo(int[] matriz){
        int minimo = matriz[0];
        for(int i = 1; i < matriz.Length; i++){
            if(matriz[i] < minimo){
                minimo = matriz[i];
            }
        }
        return minimo;
    }
    static int CalcMaximo(int[] matriz){
        int maximo = matriz[0];
        for(int i = 1; i < matriz.Length; i++){
            if(matriz[i] > maximo){
                maximo = matriz[i];
            }
        }
        return maximo;
        
    }
    static int CalcSuma(int[] matriz)
    {
        int suma = 0;
        foreach (int valor in matriz)
        {
            suma += valor;
        }
        return suma;
    }


// --------------


    static string TossCoin()
    {
        Console.WriteLine("¡Tirando una moneda!");
        Random rnd = new Random();
        int resultadoLanzamiento = rnd.Next(0, 2);

        if (resultadoLanzamiento == 0)
        {
            return "Cara";
        }
        else
        {
            return "Cruz";
        }
    }

// ---------------------
        static List<string> Nombres()
    {
        List<string> listaNombres = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
        List<string> nombres5caracteres = new List<string>();

        foreach (string nombre in listaNombres)
        {
            if (nombre.Length > 5)
            {
                nombres5caracteres.Add(nombre);
            }
        }

        return nombres5caracteres;
    }

    static void PrintLista(List<string> lista)
    {
        foreach (string elemento in lista)
        {
            Console.WriteLine(elemento);
        }
    }
}
