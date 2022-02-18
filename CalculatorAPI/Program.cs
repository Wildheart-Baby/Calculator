using CalculatorAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

calculator calc = new calculator();

app.MapGet("/add", (int start, int amount) => 
{ 
    return calc.Add(start, amount); 
});

app.MapGet("/subtract", (int start, int amount) =>
{
    return calc.Subtract(start, amount);
});

app.MapGet("/multiply", (int start, int  by) =>
{
    return calc.Multiply(start, by);
});

app.MapGet("/divide", (int start, int by) =>
{
    return calc.Divide(start, by);
});

app.MapGet("/getprime", (int number) =>
{
    return calc.GetPrime(number);
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

internal class calculator : ISimpleCalculator //I added the class here as I was unable to access the class in a seperate file
{
    
    public int Add(int start, int amount)
    {
        return start + amount;
    }
       
    public float Divide(int start, float by)
    {
        return start / by;
    }

    public int Multiply(int start, int by)
    {
        return start * by;
    }

    public int Subtract(int start, int amount)
    {
        return start - amount;
    }

    public int GetPrime(int position)
    {
        int num = 1;
        int count = 0;
        //Console.Write("Number : ");
        int n = position;
        //Console.WriteLine();
        while (true)
        {
            num++;
            if (isPrime(num))
            {
                count++;
            }
            if (count == n)
            {
                Console.WriteLine(n + "th prime number is " + num);
                break;
            }
        }
        //Console.ReadKey();
        return num;
    }

    private static bool isPrime(int number)
    {
        int counter = 0;
        for (int j = 2; j < number; j++)
        {
            if (number % j == 0)
            {
                counter = 1;
                break;
            }
        }
        if (counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}