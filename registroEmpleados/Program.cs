
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
    Console.WriteLine("Registro ingresado a sistema satisfactoriamente.");
    Console.ResetColor();
}

void mostrarDatos(int pos)
{
    Console.WriteLine("Mostrar Registros.");
    for (int i = 0; i< 10; i++)
    {
        Console.WriteLine($"Nombre: {empleados[i].nombres} \nApellidos: {empleados[i].apellidos} \nCargo: {empleados[i].cargo} \nSalario: {empleados[i].salario}");
    }
}
int menu()
{
    Console.Write("1.Agregar \n 2.Mostrar \n 3.Guardar. \n 4.Salir. \n Digite su opcion");
    int op = int.Parse(Console.ReadLine()!);
    return op;
}

void guardarEmpleados(int pos)
{
    StreamWriter archivo = new StreamWriter("C:\\Programacion\\empleados.csv");
    for (int i = 0; i < pos; i++)
    {
        archivo.WriteLine($"{empleados[i].nombres}; {empleados[i].apellidos}; {empleados[i].cargo}; {empleados[i].salario}");
    }

    archivo.Close();
    Console.WriteLine("Registros guardados satisfactoriamente.");
}

 int main()
{
    int op = 0, i = 0;

    do
    {
        Console.Write($"Registro # {i}");
        op = menu();
        switch (op)
        {
            case 1:
                AgregarEmpleados(i++);
                break;
            case 2:
                mostrarDatos(i);
                break;
            case 3:
                guardarEmpleados(i);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Archivo guardado.");
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opcion invalida.");
                Console.ResetColor();
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