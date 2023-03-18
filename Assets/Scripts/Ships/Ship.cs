using UnityEngine;

namespace Ships
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float speed;
        
        private Transform _transform;
        
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
            var direction = GetDirection();
            Move(direction);
        }

        private void Move(Vector2 direction)
        {
            _transform.Translate(direction * (speed * Time.deltaTime));
            _checkLimits.ClampFinalPosition();
        }

        private Vector2 GetDirection()
        {
            return _input.GetDirection();
        }
        
    }
}