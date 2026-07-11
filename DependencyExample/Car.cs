using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExample;

public class Car
{

     private IEngin _engin;
     
     public  Car(IEngin iengin)
    {
        _engin = iengin;
    }

    public void Drive()
    {
        _engin.Start();
        Console.WriteLine("car is runnnong");
    }
}
