using UnityEngine;

public class CGuyInput : MonoBehaviour
{
    public static CGuyInput instance;

    CoolGuyInputActions _inputActions;

    public Vector2 runningDirection { get; private set; }

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(this); }

        _inputActions = new();
    }
    private void OnEnable() => _inputActions.Enable();

    private void Update()
    {
        runningDirection = _inputActions.Main.Run.ReadValue<Vector2>();
    }

    private void OnDisable() => _inputActions.Disable();
}
