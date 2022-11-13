using System;
public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        if(n==0)
        {
            return null;
        }
        int basis = 2;
        int power = 2;
        double res = 0;
        while(res!=n)
        {
            while (res < n)
            {
                res = Math.Pow(basis, power);
                if (res != n)
                {
                    power++;
                }
                else
                {
                    return (basis, power);
                }
            }
            basis++;
            power = 2;
            res = 0;
            if(basis>=n)
            {
                return null;
            }
        }
        return (basis,power);
        
    }
}