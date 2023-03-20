using System.Linq;
using Ships.Ship;
using UnityEngine;

namespace Ships.Weapons
{
    public class WeaponController : MonoBehaviour
    {
        private IShip _ship;
        
        [SerializeField] private float fireRate;
        [SerializeField] private Projectile[] projectilePrefabs;
        [SerializeField] private Transform projectileSpawnPosition;
        
        private float _remainingTimeToShoot;
        private string _activeProjectileID;
        
        public void Configure(IShip ship)
        {
            _ship = ship;
            _activeProjectileID = projectilePrefabs.First().ID;
        }

        public void TryShoot()
        {
            _remainingTimeToShoot -= Time.deltaTime;
            
            if (_remainingTimeToShoot > 0) return;
            
            Shoot();
        }

        private void Shoot()
        {
            var prefab = projectilePrefabs.First( projectile => projectile.ID.Equals(_activeProjectileID) );
            _remainingTimeToShoot = fireRate;
            Instantiate(prefab,projectileSpawnPosition.position, projectileSpawnPosition.rotation);
        }
    }
}