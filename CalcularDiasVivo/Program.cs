class Program
{
    static void Main(string[] args)
    {        
        string data1 = "Helena 28/03/1989";
        CalculoDeDiasVivo(data1);
        string data2 = "Romeu 21/04/1950";
        CalculoDeDiasVivo(data2);
        string data3 = "Raquel 14/01/2000";
        CalculoDeDiasVivo(data3);
        string data4 = "Enzo 25/12/2021";
        CalculoDeDiasVivo(data4);
    }   
    static void CalculoDeDiasVivo(string data)
    {
        string[] separadorDeData= data.Split(" ");

        DateTime dataAtual = DateTime.Now;
        DateTime dataDeNascimento = DateTime.ParseExact(separadorDeData[1], "dd/MM/yyyy", null);
        double numeroDeDiasVivo =  Math.Floor(dataAtual.Subtract(dataDeNascimento).TotalDays);
        Console.WriteLine(separadorDeData[0] + " viveu até hoje " + numeroDeDiasVivo + " dias");
    }
}