//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.1
//     from Assets/Protagonists/BigMetal/BigMetalInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @BigMetalInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BigMetalInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BigMetalInputActions"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""3f953eb0-ff2b-40a4-b237-89ccbf50de3e"",
            ""actions"": [
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""a190dddb-e877-4b7d-acf5-7559178cc376"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3f0a3ec7-2af6-4df2-8ec3-fcbe03160181"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""988665e8-f2c6-4b17-ae77-a88a0b2a2a95"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim Up"",
                    ""type"": ""Button"",
                    ""id"": ""aac83633-da32-43bc-9e4f-896a1e2c8bb2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim Right"",
                    ""type"": ""Button"",
                    ""id"": ""fbb66e44-f560-47a2-8c6b-3a7dd572a5bb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim Down"",
                    ""type"": ""Button"",
                    ""id"": ""b466095c-4abd-4664-8fee-a4dde3cd55b8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim Left"",
                    ""type"": ""Button"",
                    ""id"": ""0c208851-e9e1-4108-853d-3dd0b0a3d719"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5811c619-2190-4bc3-a43a-a38a0760234b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ea7953c-dae1-4872-9c16-8965c740ce5b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3c6f5208-8f15-4056-bc03-603b28bb0837"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2cb0976d-63fa-4eb1-9251-2940c0ef72ab"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0c6e86c6-f223-4417-acca-3809fb9ab1e1"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a9a733f-6e5c-4635-a074-3cc778ecf8d8"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4b73853c-1b49-4068-97bf-ddf5d4e399dd"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""47b4cc98-43bd-4054-a5b4-e47fcf9ab45a"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c9f8691-feeb-4ecc-914b-606a9f2638cf"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c01520bd-a67b-4cfe-887b-c230dc245ded"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9170c7aa-f6e4-4206-b681-f5e43b3030d0"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Run = m_Main.FindAction("Run", throwIfNotFound: true);
        m_Main_Jump = m_Main.FindAction("Jump", throwIfNotFound: true);
        m_Main_Shoot = m_Main.FindAction("Shoot", throwIfNotFound: true);
        m_Main_AimUp = m_Main.FindAction("Aim Up", throwIfNotFound: true);
        m_Main_AimRight = m_Main.FindAction("Aim Right", throwIfNotFound: true);
        m_Main_AimDown = m_Main.FindAction("Aim Down", throwIfNotFound: true);
        m_Main_AimLeft = m_Main.FindAction("Aim Left", throwIfNotFound: true);
    }

    ~@BigMetalInputActions()
    {
        UnityEngine.Debug.Assert(!m_Main.enabled, "This will cause a leak and performance issues, BigMetalInputActions.Main.Disable() has not been called.");
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Main
    private readonly InputActionMap m_Main;
    private List<IMainActions> m_MainActionsCallbackInterfaces = new List<IMainActions>();
    private readonly InputAction m_Main_Run;
    private readonly InputAction m_Main_Jump;
    private readonly InputAction m_Main_Shoot;
    private readonly InputAction m_Main_AimUp;
    private readonly InputAction m_Main_AimRight;
    private readonly InputAction m_Main_AimDown;
    private readonly InputAction m_Main_AimLeft;
    public struct MainActions
    {
        private @BigMetalInputActions m_Wrapper;
        public MainActions(@BigMetalInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Run => m_Wrapper.m_Main_Run;
        public InputAction @Jump => m_Wrapper.m_Main_Jump;
        public InputAction @Shoot => m_Wrapper.m_Main_Shoot;
        public InputAction @AimUp => m_Wrapper.m_Main_AimUp;
        public InputAction @AimRight => m_Wrapper.m_Main_AimRight;
        public InputAction @AimDown => m_Wrapper.m_Main_AimDown;
        public InputAction @AimLeft => m_Wrapper.m_Main_AimLeft;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void AddCallbacks(IMainActions instance)
        {
            if (instance == null || m_Wrapper.m_MainActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainActionsCallbackInterfaces.Add(instance);
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @AimUp.started += instance.OnAimUp;
            @AimUp.performed += instance.OnAimUp;
            @AimUp.canceled += instance.OnAimUp;
            @AimRight.started += instance.OnAimRight;
            @AimRight.performed += instance.OnAimRight;
            @AimRight.canceled += instance.OnAimRight;
            @AimDown.started += instance.OnAimDown;
            @AimDown.performed += instance.OnAimDown;
            @AimDown.canceled += instance.OnAimDown;
            @AimLeft.started += instance.OnAimLeft;
            @AimLeft.performed += instance.OnAimLeft;
            @AimLeft.canceled += instance.OnAimLeft;
        }

        private void UnregisterCallbacks(IMainActions instance)
        {
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @AimUp.started -= instance.OnAimUp;
            @AimUp.performed -= instance.OnAimUp;
            @AimUp.canceled -= instance.OnAimUp;
            @AimRight.started -= instance.OnAimRight;
            @AimRight.performed -= instance.OnAimRight;
            @AimRight.canceled -= instance.OnAimRight;
            @AimDown.started -= instance.OnAimDown;
            @AimDown.performed -= instance.OnAimDown;
            @AimDown.canceled -= instance.OnAimDown;
            @AimLeft.started -= instance.OnAimLeft;
            @AimLeft.performed -= instance.OnAimLeft;
            @AimLeft.canceled -= instance.OnAimLeft;
        }

        public void RemoveCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainActions instance)
        {
            foreach (var item in m_Wrapper.m_MainActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainActions @Main => new MainActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IMainActions
    {
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnAimUp(InputAction.CallbackContext context);
        void OnAimRight(InputAction.CallbackContext context);
        void OnAimDown(InputAction.CallbackContext context);
        void OnAimLeft(InputAction.CallbackContext context);
    }
}
