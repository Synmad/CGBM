using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyDashController : MonoBehaviour
{
    [SerializeField] Rigidbody2D _rb;

    [SerializeField] float _speed, _duration;

    bool _canDash;

    bool _dashReady;

    private void OnEnable()
    {
        CGuyInput.Instance.InputActions.Main.Dash.started += DashInput;
    }

    void DashInput(InputAction.CallbackContext context)
    {
        if (_canDash) DashAction();
    }

    private void Update()
    {
        if(CGuyCollisionController.Instance.IsOnFlat && 
           CGuyStateManager.currentState != CGuyStateManager.State.Dashing)
        {
            _dashReady = true;
        }


        if (_dashReady && 
            CGuyStateManager.currentState != CGuyStateManager.State.Dashing)
        {
            _canDash = true;
        }
        else _canDash = false;
    }

    void DashAction()
    {
        if(CGuyStateManager.currentState == CGuyStateManager.State.Default)
        {
            _dashReady = false;
            CGuyStateManager.ChangeState(CGuyStateManager.State.Dashing);

            _rb.velocity = Vector2.zero;
            _rb.velocity = CGuyInput.Instance.RunDirection.normalized * _speed;

            StartCoroutine(StopDashing());
        }
    }

    IEnumerator StopDashing() 
    {
        yield return new WaitForSeconds(_duration);
        CGuyStateManager.ChangeState(CGuyStateManager.State.Default);
    }

    private void OnDisable()
    {
        CGuyInput.Instance.InputActions.Main.Dash.started -= DashInput;
    }
}
