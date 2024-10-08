using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class BMetalShootController : MonoBehaviour
{
    [SerializeField] private float _shootingCooldown;
    [SerializeField] private bool _canShoot = true;
    
    private bool _isShooting;

    private void OnEnable()
    {
        BMetalInputManager.Instance.InputActions.Main.Shoot.performed += RequestShooting;
        BMetalInputManager.Instance.InputActions.Main.Shoot.canceled += CancelShooting;
    }

    private void RequestShooting(InputAction.CallbackContext context)
    {
        if (_canShoot)
        {
            _isShooting = true;
            StartCoroutine(Shooting());
        }
    }

    private void CancelShooting(InputAction.CallbackContext context)
    {
        _isShooting = false;
    }

    private IEnumerator Shooting()
    {
        while (_isShooting)
        {
            if(_canShoot)
            {
                _canShoot = false;

                Debug.Log("Shooting");

                yield return StartCoroutine(ResetShooting());
            }
        }
    }

    private IEnumerator ResetShooting()
    {
        yield return new WaitForSeconds(_shootingCooldown);
        _canShoot = true;
    }

    private void OnDisable()
    {
        BMetalInputManager.Instance.InputActions.Main.Shoot.performed -= RequestShooting;
        BMetalInputManager.Instance.InputActions.Main.Shoot.canceled -= CancelShooting;
    }
}
