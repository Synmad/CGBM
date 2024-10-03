using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyDashController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _speed, _duration;

    [SerializeField] bool isDashing;

    private void OnEnable()
    {
        CGuyInput.inputActions.Main.Dash.started += DashInput;
    }

    void DashInput(InputAction.CallbackContext context)
    {
        DashAction();
    }

    private void Update()
    {
        if (CGuyStateManager.currentState == CGuyStateManager.State.Dashing) { isDashing = true; }
        else { isDashing = false; }
    }

    void DashAction()
    {
        if(CGuyStateManager.currentState == CGuyStateManager.State.Default)
        {
            CGuyStateManager.ChangeState(CGuyStateManager.State.Dashing);

            _rb.velocity = Vector2.zero;
            _rb.velocity = CGuyInput.runDirection.normalized * _speed;

            StartCoroutine(StopDashing());
        }
    }

    IEnumerator StopDashing() 
    {
        yield return new WaitForSeconds(_duration);
        CGuyStateManager.ChangeState(CGuyStateManager.State.Default);
    }
}
