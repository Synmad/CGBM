using UnityEngine;

public class CGuyRunController : MonoBehaviour
{
    CGuyInputManager _input;

    [SerializeField] CGuyStateManager _state;
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _runSpeed;

    float _runDirection;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _runDirection = CGuyInputManager.Instance.RunDirection.x;
    }

    void Run()
    {
        _rb.velocity = (new Vector2(_runDirection * _runSpeed, _rb.velocity.y));
    }

    private void FixedUpdate()
    {
        if(_state.currentState == CGuyStateManager.State.Default)
        {
            Run();
        }
    }
}
