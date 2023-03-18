using UnityEngine;

namespace Ships
{
    public class Ship : MonoBehaviour
    {
        [SerializeField] private float speed;
        private IInput _input;

        private Transform _transform;
        private Camera _camera;

        private void Awake()
        {
            _transform = transform;
            _camera = Camera.main;
        }
        
        public void Configure(IInput input)
        {
            _input = input;
        }

        private void Update()
        {
            var direction = GetDirection();
            Move(direction);
        }

        private void Move(Vector2 direction)
        {
            _transform.Translate(direction * (speed * Time.deltaTime));
            
            var viewPortPoint = _camera.WorldToViewportPoint(_transform.position);
            
            viewPortPoint.x = Mathf.Clamp(viewPortPoint.x, 0.03f, 0.97f);
            viewPortPoint.y = Mathf.Clamp(viewPortPoint.y, 0.03f, 0.97f);

            _transform.position = _camera.ViewportToWorldPoint(viewPortPoint);
            
        }
        
        private Vector2 GetDirection()
        {
            return _input.GetDirection();
        }
        
    }
}