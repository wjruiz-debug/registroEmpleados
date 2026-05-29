
Empleado[] empleados = new Empleado[10];

void AgregarEmpleados(int pos)
{
    Console.WriteLine("Nombres: ");
    empleados[pos].nombres = Console.ReadLine()!;
    Console.Write("Apellidos: ");
    empleados[pos].apellidos = Console.ReadLine()!;
    Console.Write("Cargo: ");
    empleados[pos].cargo = Console.ReadLine()!;
    Console.Write("Salario: ");
    empleados[pos].salario = double.Parse(Console.ReadLine()!);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Registro guardado satisfactoriamintente.");
    Console.ResetColor();
}

int menu()
{
    Console.Write("1.Agregar \n 2.Mostrar \n 3.Eliminar \n 4.Salir. \n Digite su opcion");
    int op = int.Parse(Console.ReadLine()!);
    return op;
}

 int main()
{
    int op = 0, i = 0;

    do
    {
        Console.Write($"Registro # {i + 1}");
        op = menu();
        switch (op)
        {
            case 1:
                AgregarEmpleados(i++);
                break;

                
        }
    } while (op != 4);

    return 0;
}

main();

// estructura al final, nunca inicio.
struct Empleado
{
    public string nombres;
    public string apellidos;
    public string cargo;
    public double salario;
}