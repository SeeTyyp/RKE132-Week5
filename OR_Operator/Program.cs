
//Math >= 90 OR Chemistry >= 90 OR Biology >= 90

//math && chemistry || math && biology || chemistry && biology
int math, chemistry, biology;

Console.WriteLine("Enter you Math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry results:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology results:");
biology= Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >=90))
{
    Console.WriteLine("Congratiulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application can not be approved.");
}

