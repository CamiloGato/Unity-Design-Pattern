using System.Linq;
using UnityEngine;

namespace Patterns.FactoryMethod
{
    public class EnemyFactory : MonoBehaviour
    {
        [SerializeField] private Enemy[] enemyPrefabs;
        
        public void Create(string enemyId)
        {
            Enemy enemyPrefab = GetEnemyPrefab(enemyId);
            if (enemyPrefab.Equals(null))
            {
                return;
            }
            Enemy enemy = Instantiate(enemyPrefab, Random.onUnitSphere * 3f, Quaternion.identity);
        }

        private Enemy GetEnemyPrefab(string enemyId)
        {
            return enemyPrefabs.First(enemy => enemy.Id.Equals(enemyId));
        }
        
    }
}