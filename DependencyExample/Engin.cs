using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyExample; 

public class Engin : IEngin
{
    public void Start()
    {
        Console.WriteLine("desel engin is running");
    }
}
public class patrolEngin : IEngin
{
    public void Start()
    {
        Console.WriteLine("patrol engin is running");
    }
}