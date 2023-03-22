using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Patterns.FactoryMethod
{
    [CreateAssetMenu(menuName = "Factory/Enemy Configuration", fileName = "EnemiesConfiguration", order = 0)]
    public class EnemiesConfiguration : ScriptableObject
    {
        [SerializeField] private Enemy[] enemyPrefabs;
        
        private Dictionary<string, Enemy> _idToEnemyPrefab;

        private void Awake()
        {
            // OLD WAY
            // _idToEnemyPrefab = new Dictionary<string, Enemy>();
            //foreach (Enemy enemyPrefab in enemyPrefabs)
            //{
            //    _idToEnemyPrefab.Add(enemyPrefab.Id, enemyPrefab);
            //}
            
            // NEW WAY
            _idToEnemyPrefab = enemyPrefabs.ToDictionary(enemy => enemy.Id);
            
        }
        
        public Enemy GetEnemyPrefab(string enemyId)
        {
            return _idToEnemyPrefab[enemyId];
        }
        
    }
}