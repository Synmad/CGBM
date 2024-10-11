using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyDashController : MonoBehaviour
{
    [SerializeField] CGuyStateManager _state;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] FlatSurfaceCheckController _flatChecker;

    [SerializeField] float _speed, _duration;

    bool _canDash;

    bool _dashReady;

    private void OnEnable()
    {
        CGuyInputManager.Instance.InputActions.Main.Dash.started += DashInput;
    }

    void DashInput(InputAction.CallbackContext context)
    {
        if (_canDash) DashAction();
    }

    public void ReadyDash()
    {
        _dashReady = true;
    }

    private void Update()
    {
        if(_flatChecker.IsOnFlat && 
           _state.currentState != CGuyStateManager.State.Dashing)
        {
            ReadyDash();
        }


        if (_dashReady && 
            _state.currentState != CGuyStateManager.State.Dashing)
        {
            _canDash = true;
        }
        else _canDash = false;
    }

    void DashAction()
    {
        if(_state.currentState == CGuyStateManager.State.Default)
        {
            _dashReady = false;
            _state.ChangeState(CGuyStateManager.State.Dashing);

            _rb.velocity = Vector2.zero;
            _rb.velocity = CGuyInputManager.Instance.RunDirection.normalized * _speed;

            StartCoroutine(StopDashing());
        }
    }

    IEnumerator StopDashing() 
    {
        yield return new WaitForSeconds(_duration);
        _state.ChangeState(CGuyStateManager.State.Default);
    }

    private void OnDisable()
    {
        CGuyInputManager.Instance.InputActions.Main.Dash.started -= DashInput;
    }
}
