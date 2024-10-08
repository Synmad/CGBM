using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BMetalAimManager : MonoBehaviour
{
    [SerializeField] GameObject _upAim;
    [SerializeField] GameObject _rightAim;
    [SerializeField] GameObject _downAim; 
    [SerializeField] GameObject _leftAim;

    private void OnEnable()
    {
        BMetalInputManager.Instance.InputActions.Main.AimUp.performed += EnableUpAim;
        BMetalInputManager.Instance.InputActions.Main.AimRight.performed += EnableRightAim;
        BMetalInputManager.Instance.InputActions.Main.AimDown.performed += EnableDownAim;
        BMetalInputManager.Instance.InputActions.Main.AimLeft.performed += EnableLeftAim;
    }

    void EnableUpAim(InputAction.CallbackContext context)
    {
        _upAim.SetActive(true);
        _rightAim.SetActive(false); _downAim.SetActive(false); _leftAim.SetActive(false);
    }

    void EnableRightAim(InputAction.CallbackContext context)
    {
        _rightAim.SetActive(true);
        _upAim.SetActive(false); _downAim.SetActive(false); _leftAim.SetActive(false);
    }

    void EnableDownAim(InputAction.CallbackContext context)
    {
        _downAim.SetActive(true);
        _upAim.SetActive(false); _rightAim.SetActive(false); _leftAim.SetActive(false);
    }

    void EnableLeftAim(InputAction.CallbackContext context)
    {
        _leftAim.SetActive(true);
        _upAim.SetActive(false); _rightAim.SetActive(false); _downAim.SetActive(false);
    }

    private void OnDisable()
    {
        BMetalInputManager.Instance.InputActions.Main.AimUp.performed -= EnableUpAim;
        BMetalInputManager.Instance.InputActions.Main.AimRight.performed -= EnableRightAim;
        BMetalInputManager.Instance.InputActions.Main.AimDown.performed -= EnableDownAim;
        BMetalInputManager.Instance.InputActions.Main.AimLeft.performed -= EnableLeftAim;
    }
}
