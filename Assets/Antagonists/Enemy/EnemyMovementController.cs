using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _target;

    [SerializeField] private Rigidbody2D _rb;

    private Vector2 _newPosition;
    private bool _mustMove;

    private void Update()
    {
        if(Vector2.Distance (transform.position, _target.position) > 0.5f)
        {
            _mustMove = true;
        }

        Vector2 position = transform.position;
        Vector2 direction = (_target.position - transform.position).normalized;

        _newPosition = position + direction * _speed;
    }

    private void FixedUpdate()
    {
        if (_mustMove) _rb.MovePosition(_newPosition);
    }
}
