using System;
using Patterns.Adapter;
using UnityEngine;

namespace Patterns.Strategy
{
    public class Consumer
    {
        private readonly IDataStore _dataStore;

        public Consumer(IDataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public void Save()
        {
            var data = new Data("Data2", "1234");
            _dataStore.SetData(data, "Data2");
        }
        
        public void Load()
        {
            var data = _dataStore.GetData<Data>("Data2");
            Debug.Log(data.data1);
            Debug.Log(data.data2);
        }
    }
}