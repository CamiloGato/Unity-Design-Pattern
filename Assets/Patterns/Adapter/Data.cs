using System;

namespace Patterns.Adapter
{
    [Serializable]
    public class Data
    {
        public string data1;
        public string data2;
        
        public Data(string data1, string data2)
        {
            this.data1 = data1;
            this.data2 = data2;
        }
        
    }
}