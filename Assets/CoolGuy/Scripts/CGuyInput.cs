using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyInput : MonoBehaviour
{
    public static CGuyInput instance;

    public static CoolGuyInputActions inputActions { get; private set; } 

    public static Vector2 runDirection { get; private set; }

    private void Awake()
    {
        if (instance == null) { instance = this; }
        else { Destroy(this); }

        inputActions = new();
    }
    private void OnEnable() => inputActions.Enable();

    private void Update()
    {
        runDirection = inputActions.Main.Run.ReadValue<Vector2>();
    }

    private void OnDisable() => inputActions.Disable();
}
