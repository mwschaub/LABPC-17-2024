namespace T1MWSG1243424{
    class Program
    {

        static void Main (string [] args)
        {
        Console.WriteLine("Mi segundo programa");
        string sNombre = "";
        int sEdad = 0;
        string sCarrera = "";
        int sCarne = 0;
        Console.WriteLine("Ingrese nombre");
        sNombre = Console.ReadLine();
        Console.WriteLine("Ingrese edad");
        sEdad = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese carrera");
        sCarrera = Console.ReadLine();
        Console.WriteLine("Ingrese carne");
        sCarne = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Mi segundo programa \n Nombre: " + sNombre + "\n Edad: "+sEdad+"\n Carrera: " + sCarrera+ "\n Carné: "+sCarne);
        Console.WriteLine("Soy " + sNombre + " tengo "+sEdad+" años y estudio la carrera de " + sCarrera+ " Mi numero de carné es: "+sCarne);
        Console.ReadKey();
        }
    }
}