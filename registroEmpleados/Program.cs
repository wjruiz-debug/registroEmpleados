
Empleado[] empleados = new Empleado[10];

void AgregarEmpleados(int pos)
{
    Console.WriteLine("Nombres: ");
    empleados[pos].nombres = Console.ReadLine()!;
    Console.Write("Apellidos: ");
    empleados[pos].apellidos = Console.ReadLine()!;
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine()!;
    Console.WriteLine("Salario: ");
    empleados[pos].salario = double.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado satisfactoriamente.");
    Console.ResetColor();
}

// estructura al final, nunca inicio.
struct Empleado
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}