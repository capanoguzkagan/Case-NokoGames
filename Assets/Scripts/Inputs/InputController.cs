// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputs/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""cac2e02d-2794-498a-85d5-0cdd31cb6c0a"",
            ""actions"": [
                {
                    ""name"": ""Joystick"",
                    ""type"": ""Value"",
                    ""id"": ""2a9c6241-1aa7-4fc8-8783-4abe5cba518d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Release"",
                    ""type"": ""Button"",
                    ""id"": ""85838787-9cbc-44eb-8672-85c63f0832c0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""d89b7ac4-6e05-4488-9ef5-8e64bd7b1f53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2ec2de8e-97ed-4ac7-85b3-66fef0c958b6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Joystick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a3d0ac3-ec43-4e98-a2ba-5d69dfeec4dc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8412fbbd-9428-4aa0-b4dc-70a449ba5bad"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Release"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d75daa0c-ee3f-46f2-a227-4bc666c8f8e1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6e051c4-27de-4b4a-bd70-a9d39484738d"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Joystick = m_Movement.FindAction("Joystick", throwIfNotFound: true);
        m_Movement_Release = m_Movement.FindAction("Release", throwIfNotFound: true);
        m_Movement_Press = m_Movement.FindAction("Press", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Joystick;
    private readonly InputAction m_Movement_Release;
    private readonly InputAction m_Movement_Press;
    public struct MovementActions
    {
        private @InputController m_Wrapper;
        public MovementActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Joystick => m_Wrapper.m_Movement_Joystick;
        public InputAction @Release => m_Wrapper.m_Movement_Release;
        public InputAction @Press => m_Wrapper.m_Movement_Press;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Joystick.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJoystick;
                @Joystick.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJoystick;
                @Joystick.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJoystick;
                @Release.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRelease;
                @Release.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRelease;
                @Release.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRelease;
                @Press.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnPress;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Joystick.started += instance.OnJoystick;
                @Joystick.performed += instance.OnJoystick;
                @Joystick.canceled += instance.OnJoystick;
                @Release.started += instance.OnRelease;
                @Release.performed += instance.OnRelease;
                @Release.canceled += instance.OnRelease;
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnJoystick(InputAction.CallbackContext context);
        void OnRelease(InputAction.CallbackContext context);
        void OnPress(InputAction.CallbackContext context);
    }
}
