using LAB07;

Equation[] equations =
{
new LinearEquation(2, -4),
new QuadraticEquation(1, -5, 6),
new LinearEquation(3, 9),
new QuadraticEquation(1, 2, 1),
new QuadraticEquation(1, 0, 4),
new LinearEquation(5, -10),
new QuadraticEquation(1, -3, 2),
new QuadraticEquation(2, 4, -6),
new LinearEquation(-2, 8),
new QuadraticEquation(1, 4, 5)
};

double left = -10;
double right = 10;

int maxRoots = -1;
Equation equationWithMaxRoots = equations[0];

foreach (Equation equation in equations)
{
    Console.WriteLine(equation);

    double[] roots = equation.Solve();

    Console.Write("Корни: ");

    if (roots.Length == 0)
    {
        Console.WriteLine("действительных корней нет");
    }
    else
    {
        foreach (double root in roots)
        {
            Console.Write($"{root:F2} ");
        }

        Console.WriteLine();
    }

    Console.WriteLine(
        $"Наличие действительных корней: {equation.HasRealRoots}");

    Console.WriteLine(
        $"Корни на отрезке [{left}; {right}]: " +
        $"{equation.HasRootsInRange(left, right)}");

    Console.WriteLine();

    if (roots.Length > maxRoots)
    {
        maxRoots = roots.Length;
        equationWithMaxRoots = equation;
    }
}

Console.WriteLine("Уравнение с наибольшим количеством корней:");
Console.WriteLine(equationWithMaxRoots);
Console.WriteLine($"Количество корней: {maxRoots}");

Console.WriteLine();

QuadraticEquation equationWithMinD = null;

foreach (Equation equation in equations)
{
    if (equation is QuadraticEquation quadratic)
    {
        quadratic.Solve();

        if (equationWithMinD == null ||
            quadratic.Discriminant < equationWithMinD.Discriminant)
        {
            equationWithMinD = quadratic;
        }
    }
}

Console.WriteLine("Квадратное уравнение с минимальным дискриминантом:");

if (equationWithMinD != null)
{
    Console.WriteLine(equationWithMinD);
    Console.WriteLine($"Дискриминант: {equationWithMinD.Discriminant:F2}");
}
