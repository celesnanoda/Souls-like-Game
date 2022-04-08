// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player Movement"",
            ""id"": ""6288b718-710c-4f4d-907f-4484b769b1a4"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""11af0cf0-cb91-450a-8d58-5d4fe7b220e8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ebca7be2-58db-4163-b9b8-509b481873b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7da61399-ba16-4413-a1a5-558d8974a92a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2af6c277-409e-4257-9479-3fb50f3ec1c9"",
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
                    ""id"": ""292c1295-b237-4673-899a-4f76200c4340"",
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
                    ""id"": ""d45dfdeb-8f5c-4f96-968b-c05c7597be57"",
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
                    ""id"": ""0705e15c-54f3-43fa-a08a-fbe73a9a7b64"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""63ac35e9-4ad8-47b2-9625-6d308b41cdc2"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11ff1e48-1855-4aa9-a73e-655c4dc1d281"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector2"",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""871d7059-3c51-4f2f-af4d-4cd2f68ebea1"",
            ""actions"": [
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""81dcb03d-6fc8-4b2e-853d-d975c95c5eb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RB"",
                    ""type"": ""Button"",
                    ""id"": ""62002466-a92e-4c12-841c-5c47fa4cac0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RT"",
                    ""type"": ""Button"",
                    ""id"": ""da39fe09-2f0e-4ebb-86a6-7ac8309427a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5659eaaf-ac10-427e-9e08-a97cbe1a13eb"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cf10a24-ae3c-472e-9669-119aefa4dd2f"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2c667b8-646b-48c9-9aa1-4215fae9c576"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3389f19f-579c-430c-a2c2-0650d9df371e"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Roll = m_PlayerActions.FindAction("Roll", throwIfNotFound: true);
        m_PlayerActions_RB = m_PlayerActions.FindAction("RB", throwIfNotFound: true);
        m_PlayerActions_RT = m_PlayerActions.FindAction("RT", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Roll;
    private readonly InputAction m_PlayerActions_RB;
    private readonly InputAction m_PlayerActions_RT;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Roll => m_Wrapper.m_PlayerActions_Roll;
        public InputAction @RB => m_Wrapper.m_PlayerActions_RB;
        public InputAction @RT => m_Wrapper.m_PlayerActions_RT;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Roll.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @RB.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RB.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RB.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRB;
                @RT.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRT;
                @RT.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRT;
                @RT.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRT;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @RB.started += instance.OnRB;
                @RB.performed += instance.OnRB;
                @RB.canceled += instance.OnRB;
                @RT.started += instance.OnRT;
                @RT.performed += instance.OnRT;
                @RT.canceled += instance.OnRT;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnRoll(InputAction.CallbackContext context);
        void OnRB(InputAction.CallbackContext context);
        void OnRT(InputAction.CallbackContext context);
    }
}
