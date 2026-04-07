using System.Net.Http.Headers;
using System;
using System.Net.Security;

public class Program
{
    public static void Main(string[] args)
    {   
        
        Product pro = new Product(); 
        pro.Price +=1; 
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Hello world"); 
            A.Price += 1 ; 
            A.Work += 10;
        }
        Console.WriteLine(A.Work); 
    }
// why is that my 
}