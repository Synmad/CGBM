using UnityEngine;

public class BMetalRunController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _runSpeed;

    float _runDirection;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _runDirection = BMetalInputManager.Instance.RunDirection.x;
    }

    void Run() => _rb.velocity = (new Vector2(_runDirection * _runSpeed, _rb.velocity.y));

    private void FixedUpdate()
    {
        Run();
    }
}
