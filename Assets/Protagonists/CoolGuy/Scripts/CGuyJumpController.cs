using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyJumpController : MonoBehaviour
{
    [SerializeField] CGuyStateManager _state;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] FlatSurfaceCheckController _flatChecker;

    [SerializeField] float _defaultGravity, _upwardGravity, _downwardGravity;
    [SerializeField] float _jumpHeight, _lowJumpWeight;

    private void OnEnable()
    {
        CGuyInputManager.Instance.InputActions.Main.Jump.started += JumpInput;
    }

    void JumpInput(InputAction.CallbackContext context)
    {
        if (_flatChecker.IsOnFlat) JumpAction();
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
            if (CGuyInputManager.Instance.InputActions.Main.Jump.IsPressed() ||
                _state.currentState == CGuyStateManager.State.Dashing)
                _rb.gravityScale = _upwardGravity;
            else _rb.gravityScale = _upwardGravity + _lowJumpWeight;
        }
        else if (_rb.velocity.y < 0) _rb.gravityScale = _downwardGravity;
    }

    private void OnDisable() => CGuyInputManager.Instance.InputActions.Main.Jump.started -= JumpInput;
}
