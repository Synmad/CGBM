using System;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyJumpController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _defaultGravity, _upwardGravity, _downwardGravity;
    [SerializeField] float _jumpSpeed, _lowJumpWeight;

    [SerializeField] Vector2 _velocity;

    private void OnEnable() => CGuyInput.inputActions.Main.Jump.started += JumpInput;

    private void JumpInput(InputAction.CallbackContext context)
    {
        if (CGuyCollisionController.instance.isOnFlat) JumpAction();
    }

    void JumpAction()
    {

    }

    private void FixedUpdate()
    {
        if (_rb.velocity.y == 0) _rb.gravityScale = _defaultGravity;
        else if (_rb.velocity.y > 0)
        {
            if (CGuyInput.inputActions.Main.Jump.IsPressed() || CGuyStateManager.currentState == CGuyStateManager.State.Dashing)
            { _rb.gravityScale = _upwardGravity; }
            else { _rb.gravityScale = _upwardGravity + _lowJumpWeight; }
        }
        else if (_rb.velocity.y < 0) _rb.gravityScale = _downwardGravity;
    }

    private void OnDisable() => CGuyInput.inputActions.Main.Jump.started -= JumpInput;
}
