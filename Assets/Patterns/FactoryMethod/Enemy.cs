using UnityEngine;

namespace Patterns.FactoryMethod
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] private EnemyId id;
        
        public string Id => id.Value;

    }
}