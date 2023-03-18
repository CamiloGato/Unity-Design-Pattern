using UnityEngine;

namespace Patterns.Adapter
{
    public class Consumer : MonoBehaviour
    {
        
        private IDataStore _fileDataStoreAdapter;
        
        private void Awake()
        {
            _fileDataStoreAdapter = new PlayerPrefsDataStoreAdapter();
            var data = new Data("data1", "123");
            _fileDataStoreAdapter.SetData(data, "Data1");
        }

        private void Start()
        {
            var data = _fileDataStoreAdapter.GetData<Data>("Data1");
            print(data.data1);
            print(data.data2);
        }
    }
}