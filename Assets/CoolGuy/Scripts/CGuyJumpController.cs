using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyJumpController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _defaultGravity, _upwardGravity, _downwardGravity;
    [SerializeField] float _jumpHeight, _lowJumpWeight;

    [SerializeField] Vector2 _velocity;

    private void OnEnable()
    {
        CGuyInput.Instance.InputActions.Main.Jump.started += JumpInput;
    }

    void JumpInput(InputAction.CallbackContext context)
    {
        if (CGuyCollisionController.Instance.IsOnFlat) JumpAction();
    }

    void JumpAction()
    {
        float jumpSpeed = Mathf.Sqrt(-2 * Physics2D.gravity.y * _jumpHeight);
        if (_rb.velocity.y > 0)
        {
            jumpSpeed = Mathf.Max(jumpSpeed - _rb.velocity.y, 0);
        }

        _rb.velocity = new Vector2(_rb.velocity.x, jumpSpeed);
    }   

    private void FixedUpdate()
    {
        if (_rb.velocity.y == 0) _rb.gravityScale = _defaultGravity;
        else if (_rb.velocity.y > 0)
        {
            if (CGuyInput.Instance.InputActions.Main.Jump.IsPressed() ||
                CGuyStateManager.currentState == CGuyStateManager.State.Dashing)
                _rb.gravityScale = _upwardGravity;
            else _rb.gravityScale = _upwardGravity + _lowJumpWeight;
        }
        else if (_rb.velocity.y < 0) _rb.gravityScale = _downwardGravity;
    }

    private void OnDisable() => CGuyInput.Instance.InputActions.Main.Jump.started -= JumpInput;
}
