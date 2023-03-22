using System;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Patterns.FactoryMethod
{
    public class EnemySpawner : MonoBehaviour
    {
        
        [SerializeField] private EnemyId enemyId1;
        [SerializeField] private EnemyId enemyId2;
        [SerializeField] private EnemiesConfiguration enemyFactoryConfig;
        
        private EnemyFactory _enemyFactory;

        private void Awake()
        {
            _enemyFactory = new EnemyFactory(Instantiate(enemyFactoryConfig));
        }

        private void Update()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            {
                _enemyFactory.Create(enemyId1.Value);
            }
            if (UnityEngine.Input.GetKeyDown(KeyCode.W))
            {
                _enemyFactory.Create(enemyId2.Value);
            }
        }
    }
}