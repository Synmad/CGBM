using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class BMetalShootController : MonoBehaviour
{
    [SerializeField] private BMetalAimManager _aim;
    private BMetalBulletPoolController _bulletPool;

    [SerializeField] private float _shootingCooldown;
    [SerializeField] private bool _canShoot = true;

    private GameObject _bullet;
    private bool _isShooting;

    private void Awake()
    {
        _bulletPool = BMetalBulletPoolController.Instance;
    }

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
            StartCoroutine(ShootingLoop());
        }
    }

    private void CancelShooting(InputAction.CallbackContext context)
    {
        _isShooting = false;
    }

    private IEnumerator ShootingLoop()
    {
        while (_isShooting)
        {
            if (_canShoot)
            {
                _canShoot = false;
                Shoot();
                yield return StartCoroutine(ResetShooting());
            }
        }
    }

    private void Shoot()
    {
        _bullet = _bulletPool.GetPooledBullets();

        if (_bullet != null )
        {
            _bullet.transform.position = _aim.EnabledAim.transform.position;
            _bullet.SetActive(true);
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
