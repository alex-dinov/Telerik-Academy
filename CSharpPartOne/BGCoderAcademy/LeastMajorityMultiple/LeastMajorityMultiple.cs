using System;

class LeastMajorityMultiple
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int LMM = 1;
        
        for (int i = LMM; i >=0; LMM++)
        {
            if (LMM%a==0 && LMM%b==0 && LMM%c==0)
            {
                break;
            }
            else if (LMM % a == 0 && LMM % b == 0 && LMM % d == 0)
            {
                break;
            }
            else if (LMM % a == 0 && LMM % b == 0 && LMM % e == 0)
            {
                break;
            }
            else if (LMM % b == 0 && LMM % c== 0 && LMM % d == 0)
            {
                break;
            }
            else if (LMM % b== 0 && LMM % d == 0 && LMM % e == 0)
            {
                break;
            }
            else if (LMM % c == 0 && LMM % d == 0 && LMM % e == 0)
            {
                break;
            }
            else if (LMM % a == 0 && LMM % c == 0 && LMM % d == 0)
            {
                break;
            }
            else if (LMM % a == 0 && LMM % c == 0 && LMM % e == 0)
            {
                break;
            }
            else if (LMM % a == 0 && LMM % d == 0 && LMM % e == 0)
            {
                break;
            }
            else if (LMM%b==0 && LMM%c==0 && LMM%e==0)
            {
                break;
            }
        }
        Console.WriteLine(LMM);
    }
}

