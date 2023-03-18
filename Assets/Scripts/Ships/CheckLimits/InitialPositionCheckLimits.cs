using UnityEngine;

namespace Ships.CheckLimits
{
    class InitialPositionCheckLimits : ICheckLimits
    {
        
        private readonly Transform _transform;
        private readonly float _maxDistance;
        private readonly Vector3 _initialPosition;
        
        
        public InitialPositionCheckLimits(Transform transform, float maxDistance)
        {
            _transform = transform;
            _initialPosition = transform.position;
            _maxDistance = maxDistance;
        }

        public void ClampFinalPosition()
        {
            var currentPosition = _transform.position;
            var finalPosition = currentPosition;
            var distanceX = Mathf.Abs(currentPosition.x - _initialPosition.x);

            if (distanceX > _maxDistance)
            {
                finalPosition.x = currentPosition.x > _initialPosition.x
                    ? _initialPosition.x + _maxDistance
                    : _initialPosition.x - _maxDistance;
            }
            
            var distanceY = Mathf.Abs(currentPosition.y - _initialPosition.y);
            
            if (distanceY > _maxDistance)
            {
                finalPosition.y = currentPosition.y > _initialPosition.y
                    ? _initialPosition.y + _maxDistance
                    : _initialPosition.y - _maxDistance;
            }
            
            _transform.position = finalPosition;
            
        }
    }
}