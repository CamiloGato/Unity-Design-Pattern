using UnityEngine;

namespace Patterns.FactoryMethod
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] private string id;
        
        public string Id => id;

    }
}