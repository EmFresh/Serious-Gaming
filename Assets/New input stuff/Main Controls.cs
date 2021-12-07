// GENERATED AUTOMATICALLY FROM 'Assets/New input stuff/Main Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Main Controls"",
    ""maps"": [
        {
            ""name"": ""PlayMode"",
            ""id"": ""e82eb1ee-cb44-4e94-a417-e0b4d251b3eb"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""2bd50cfe-7790-46d7-bde3-2e6393205102"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""539cf971-208b-4044-a266-229f2083247b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""28e2e30e-d02b-4498-a910-aae6062b61ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Panic"",
                    ""type"": ""Button"",
                    ""id"": ""e8140cfc-4787-4a4d-b7fd-50497efa982e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""67fb2d63-a880-40c0-98e5-65bf42975d6a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f9417c83-e212-48db-a459-bac3345f9377"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""376171f4-a1ea-40b4-b749-a850477dec71"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a64d3c45-14f2-4689-ab65-ec08aa82a30d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c60e7823-f467-4411-ada4-5ed6f44d7a82"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""53dd034c-ac52-4b27-82e3-5c4e885aa284"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""927a008f-fa3c-496e-be3f-a08de38c5d53"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8fda85f9-7a48-4993-bcc8-109bf60e94db"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ca9a5e17-888c-4b08-a2ec-65d77bcd207d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""48ed85aa-fbe7-4d01-8bf6-f124ff962eb3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""04f1ac4f-341a-4b38-9b19-d090e55bfce1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d2bc43-237b-4d1e-b029-1b39167b80ae"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""0cd11f7f-a256-4abe-a554-d09671390043"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""63820e0e-47ea-48fc-b04d-eefadf4c021d"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f765aed8-17b5-4e17-98da-892d3cac4626"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c0fd8927-98c7-44d2-b190-53bbc3ee965b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9de5c29b-39df-4ffe-b865-0f7ee9f067ca"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""6326af5d-6d51-46bb-b194-6f6ceff8e345"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""dfd4bb32-9a00-4042-a7b6-c4a28a2d43d1"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3799ec24-55a5-4077-a434-d15edcb419b2"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""240d8c00-fd07-4589-bdff-e49f78f5dca3"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1595d261-6a48-42de-ba33-006ef3f1b484"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""49b13c2f-102a-41d4-9fa3-fc9f56989876"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76dfebc9-ebb8-4991-a701-279bce65ade7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Panic"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayMode
        m_PlayMode = asset.FindActionMap("PlayMode", throwIfNotFound: true);
        m_PlayMode_Movement = m_PlayMode.FindAction("Movement", throwIfNotFound: true);
        m_PlayMode_Rotation = m_PlayMode.FindAction("Rotation", throwIfNotFound: true);
        m_PlayMode_Jump = m_PlayMode.FindAction("Jump", throwIfNotFound: true);
        m_PlayMode_Panic = m_PlayMode.FindAction("Panic", throwIfNotFound: true);
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

    // PlayMode
    private readonly InputActionMap m_PlayMode;
    private IPlayModeActions m_PlayModeActionsCallbackInterface;
    private readonly InputAction m_PlayMode_Movement;
    private readonly InputAction m_PlayMode_Rotation;
    private readonly InputAction m_PlayMode_Jump;
    private readonly InputAction m_PlayMode_Panic;
    public struct PlayModeActions
    {
        private @MainControls m_Wrapper;
        public PlayModeActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayMode_Movement;
        public InputAction @Rotation => m_Wrapper.m_PlayMode_Rotation;
        public InputAction @Jump => m_Wrapper.m_PlayMode_Jump;
        public InputAction @Panic => m_Wrapper.m_PlayMode_Panic;
        public InputActionMap Get() { return m_Wrapper.m_PlayMode; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayModeActions set) { return set.Get(); }
        public void SetCallbacks(IPlayModeActions instance)
        {
            if (m_Wrapper.m_PlayModeActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnMovement;
                @Rotation.started -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnRotation;
                @Jump.started -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnJump;
                @Panic.started -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnPanic;
                @Panic.performed -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnPanic;
                @Panic.canceled -= m_Wrapper.m_PlayModeActionsCallbackInterface.OnPanic;
            }
            m_Wrapper.m_PlayModeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Panic.started += instance.OnPanic;
                @Panic.performed += instance.OnPanic;
                @Panic.canceled += instance.OnPanic;
            }
        }
    }
    public PlayModeActions @PlayMode => new PlayModeActions(this);
    public interface IPlayModeActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotation(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPanic(InputAction.CallbackContext context);
    }
}
