using System;

class LinearEquation
{
    public double a;
    public double b;

    public LinearEquation(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public virtual void Solve()
    {
        if (a == 0)
        {
            if (b == 0)
                Console.WriteLine("Phương trình vô số nghiệm.");
            else
                Console.WriteLine("Phương trình vô nghiệm.");
        }
        else
        {
            double x = -b / a;
            Console.WriteLine($"Nghiệm của phương trình bậc 1: x = {x}");
        }
    }
}

class QuadraticEquation : LinearEquation
{
    public double c;

    public QuadraticEquation(double a, double b, double c) : base(a, b)
    {
        this.c = c;
    }

    public override void Solve()
    {
        if (a == 0)
        {
            // Nếu a = 0 thì quay về giải bậc 1
            Console.WriteLine("Phương trình trở thành bậc 1:");
            base.Solve();
            return;
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm (delta < 0).");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Nhập a = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập b = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Nhập c = ");
        double c = double.Parse(Console.ReadLine());

        QuadraticEquation qe = new QuadraticEquation(a, b, c);

        Console.WriteLine("\n=== KẾT QUẢ ===");
        qe.Solve();
    }
}
