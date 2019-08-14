using System;
using System.Linq;
using System.Threading.Tasks;
using SharpPad;

namespace Template
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await "Hello World".Dump();
        }
    }
}