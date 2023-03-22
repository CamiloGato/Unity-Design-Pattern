using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Patterns.FactoryMethod
{
    public class EnemyFactory
    {
        private readonly EnemiesConfiguration _enemiesConfiguration;

        public EnemyFactory(EnemiesConfiguration enemiesConfiguration)
        {
            _enemiesConfiguration = enemiesConfiguration;
        }

        public void Create(string enemyId)
        {
            Enemy enemyPrefab = _enemiesConfiguration.GetEnemyPrefab(enemyId);
            if (enemyPrefab.Equals(null))
            {
                throw new Exception("Enemy prefab not found");
            }
            UnityEngine.Object.Instantiate(enemyPrefab, Random.onUnitSphere * 3f, Quaternion.identity);
        }
        
    }
}