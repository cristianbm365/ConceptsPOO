// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");
Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Luz",
    LastName = "Mora",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1815453.45M
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Juan",
    LastName = "Peña",
    BirthDate = new Date(1992, 5, 23),
    HiringDate = new Date(2023, 3, 15),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
Console.WriteLine(employee2);

//try
//{
//    Console.WriteLine(new Date(2024, 2, 29));
//    Console.WriteLine(new Date(1974, 9, 23));
//    Console.WriteLine(new Date(1985, 11, 5));
//}
//catch (Exception error)
//{
//    Console.WriteLine(error.Message);
//}





Console.ReadKey();