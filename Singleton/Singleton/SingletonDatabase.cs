using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Singleton
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> capitals= new Dictionary<string, int>();
        private static int instanceCount;
        public static int Count => instanceCount;

        private SingletonDatabase()
        {
            capitals.Add("A", 1);
            capitals.Add("B", 2);
            capitals.Add("C", 3);

        }
        public int GetInfo(string name)
        {
            return capitals[name];
        }
        private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() =>
        {
            instanceCount++;
            return new SingletonDatabase();
        });

        public static IDatabase Instance => instance.Value;
    }
}
