using UnityEngine;
using UnityEngine.InputSystem;

public class CGuyInputManager : MonoBehaviour
{
    public static CGuyInputManager Instance;

    public CoolGuyInputActions InputActions { get; private set; } 

    public Vector2 RunDirection { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this) Destroy(this); 
        else Instance = this;

        InputActions = new();
    }

    private void OnEnable() => InputActions.Enable();

    private void Update()
    {
        RunDirection = InputActions.Main.Run.ReadValue<Vector2>();
    }

    private void OnDisable() => InputActions.Disable();
}
