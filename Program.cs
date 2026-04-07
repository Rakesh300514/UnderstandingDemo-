using System.Net.Http.Headers;
using System; 

namespace Hello; 
public class Program
{
    public static void Main(string[] args)
    {   
        Hello A = new Hello();
        
        A.Price = 10;  
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello world"); 
            A.Price += 1 ; 
        }
    }
// why is that my 
}