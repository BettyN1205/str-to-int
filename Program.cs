using System;

namespace StringPars
{
    class Program
{
    static void Main(string[] args)
    {
        int square=0;
        Console.WriteLine("Please enter numbers:");
        string input = Console.ReadLine();
        string[] inputStr=input.Split(',');
        int[] num=new int[inputStr.Length];
        for(int i=0;i<inputStr.Length;i++){
            num[i]=Convert.ToInt32(inputStr[i]);
            //num[i]=int.Parse(inputStr[i]);
            if(num[i]%2==0){
                square=num[i]*num[i];
                Console.WriteLine("{0}^2 = {1}",num[i],square);
            }
        }
    }
}
}

