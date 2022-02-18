using CalculatorAPI;
using System.Data.SqlClient;

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
    
    public int Add(int start, int amount) //the functions used by the api to return the results, it will also add the result to the database.
    {
        int tmp = start + amount;
        OutputResults(tmp.ToString(), "add");
        return tmp;
    }
       
    public float Divide(int start, float by)
    {
        float tmp = start / by;
        OutputResults(tmp.ToString(), "divide");
        return tmp;
    }

    public int Multiply(int start, int by)
    {
        int tmp = start* by;
        OutputResults(tmp.ToString(), "multiply");
        return tmp;
    }

    public int Subtract(int start, int amount)
    {
        int tmp = start - amount;
        OutputResults(tmp.ToString(), "subtract");
        return tmp;
    }

    public int GetPrime(int position) //a function to return the position of the prime number based on the integer passed to it
    {
        int num = 1;
        int count = 0;
        int n = position;
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
        OutputResults(num.ToString(), "get prime");
        return num;
    }

    private static bool isPrime(int number) //this function checks through numbers to get prime numbers 
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

    public void OutputResults(string answer, string type) //this function will output the result from the method to the console
    {
        Console.WriteLine("The answer to the " + type + " method was " + answer);
        String tmp = "The answer to the " + type + " method was " + answer;

        String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Users\\Wildheart\\Source\\Repos\\Calculator\\Calculator\\ResultsDB.mdf;Integrated Security=True";
        String sql = "INSERT INTO Outputs (Result) VALUES (@Result)";

        SqlConnection con = new SqlConnection(ConnectionString);

        SqlCommand cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.Parameters.AddWithValue("@Result", tmp);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}