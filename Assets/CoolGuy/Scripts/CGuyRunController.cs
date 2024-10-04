using UnityEngine;

public class CGuyRunController : MonoBehaviour
{
    CGuyInput _input;
    
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _runSpeed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(CGuyStateManager.currentState == CGuyStateManager.State.Default)
        {
            _rb.velocity = (new Vector2(CGuyInput.Instance.RunDirection.x * _runSpeed, _rb.velocity.y));
        }
    }
}
