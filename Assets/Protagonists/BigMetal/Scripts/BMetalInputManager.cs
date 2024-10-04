using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMetalInputManager : MonoBehaviour
{
    public static BMetalInputManager Instance;

    public BigMetalInputActions InputActions { get; private set; }

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

