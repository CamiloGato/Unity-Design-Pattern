using Input;
using Ships.CheckLimits;
using Ships.Weapons;
using UnityEngine;

namespace Ships
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float fireRate;
        [SerializeField] private Projectile projectilePrefab;
        [SerializeField] private Transform projectileSpawnPosition;
        
        private Transform _transform;
        private float _remainingTimeToShoot;
        
        private IInput _input;
        private ICheckLimits _checkLimits;


        private void Awake()
        {
            _transform = transform;
        }
        
        public void Configure(IInput input, ICheckLimits checkLimits)
        {
            _input = input;
            _checkLimits = checkLimits;
        }
        
        private void Update()
        {
            var direction = _input.GetDirection();
            Move(direction);
            TryShoot();
        }

        private void TryShoot()
        {
            _remainingTimeToShoot -= Time.deltaTime;
            
            if (_remainingTimeToShoot > 0) return;
            
            if (_input.IsFireActionPressed())
                Shoot();
        }

        private void Shoot()
        {
            _remainingTimeToShoot = fireRate;
            Instantiate(projectilePrefab,projectileSpawnPosition.position, projectileSpawnPosition.rotation);
        }

        private void Move(Vector2 direction)
        {
            _transform.Translate(direction * (speed * Time.deltaTime));
            _checkLimits.ClampFinalPosition();
        }

    }
}