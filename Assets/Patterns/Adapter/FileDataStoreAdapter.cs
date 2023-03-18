﻿using System.IO;
using UnityEngine;

namespace Patterns.Adapter
{
    class FileDataStoreAdapter : IDataStore
    {
        public void SetData<T>(T data, string name)
        {
            var json = JsonUtility.ToJson(data);
            var path = Path.Combine(Application.dataPath, name);
            File.WriteAllText(path, json);
        }

        public T GetData<T>(string name)
        {
            var path = File.ReadAllText(Path.Combine(Application.dataPath, name));
            var json = File.ReadAllText(path);
            return JsonUtility.FromJson<T>(json);
        }
    }
}