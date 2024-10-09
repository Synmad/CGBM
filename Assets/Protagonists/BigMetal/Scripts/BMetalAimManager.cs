using UnityEngine;
using UnityEngine.InputSystem;

public class BMetalAimManager : MonoBehaviour
{
    public static BMetalAimManager Instance { get; private set; }

    [SerializeField] GameObject _upAim;
    [SerializeField] GameObject _rightAim;
    [SerializeField] GameObject _downAim; 
    [SerializeField] GameObject _leftAim;

    public GameObject EnabledAim { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); }
        else { Instance = this; }
    }

    private void OnEnable()
    {
        EnableAim(_rightAim);

        BMetalInputManager.Instance.InputActions.Main.AimUp.performed += EnableUpAim;
        BMetalInputManager.Instance.InputActions.Main.AimRight.performed += EnableRightAim;
        BMetalInputManager.Instance.InputActions.Main.AimDown.performed += EnableDownAim;
        BMetalInputManager.Instance.InputActions.Main.AimLeft.performed += EnableLeftAim;
    }

    #region Aim Enabling Methods
    void EnableUpAim(InputAction.CallbackContext context)
    {
        EnableAim(_upAim);
        _rightAim.SetActive(false); _downAim.SetActive(false); _leftAim.SetActive(false);
    }

    void EnableRightAim(InputAction.CallbackContext context)
    {
        EnableAim(_rightAim);
        _upAim.SetActive(false); _downAim.SetActive(false); _leftAim.SetActive(false);
    }

    void EnableDownAim(InputAction.CallbackContext context)
    {
        EnableAim(_downAim);
        _upAim.SetActive(false); _rightAim.SetActive(false); _leftAim.SetActive(false);
    }

    void EnableLeftAim(InputAction.CallbackContext context)
    {
        EnableAim(_leftAim);
        _upAim.SetActive(false); _rightAim.SetActive(false); _downAim.SetActive(false);
    }

    void EnableAim(GameObject newAim)
    {
        newAim.SetActive(true);
        EnabledAim = newAim;
    }
    #endregion

    private void OnDisable()
    {
        BMetalInputManager.Instance.InputActions.Main.AimUp.performed -= EnableUpAim;
        BMetalInputManager.Instance.InputActions.Main.AimRight.performed -= EnableRightAim;
        BMetalInputManager.Instance.InputActions.Main.AimDown.performed -= EnableDownAim;
        BMetalInputManager.Instance.InputActions.Main.AimLeft.performed -= EnableLeftAim;
    }
}
