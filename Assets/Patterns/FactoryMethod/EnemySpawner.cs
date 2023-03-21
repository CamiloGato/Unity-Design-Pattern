using System;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Patterns.FactoryMethod
{
    public class EnemySpawner : MonoBehaviour
    {
        
        [SerializeField] private string enemyId1;
        [SerializeField] private string enemyId2;
        
        [SerializeField] private EnemyFactory enemyFactory;

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            {
                enemyFactory.Create(enemyId1);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.W))
            {
                enemyFactory.Create(enemyId2);
            }
        }
    }
}