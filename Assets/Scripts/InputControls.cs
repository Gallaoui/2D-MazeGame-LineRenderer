// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""7dbadeac-5110-4944-a143-a547eb506f85"",
            ""actions"": [
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""fc555fbb-53ec-46e2-a05b-2fc0e684a2c9"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Solution"",
                    ""type"": ""Button"",
                    ""id"": ""f800e725-8b91-4c5f-bdf0-17ec22d97e44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e3e097a-bbdc-4e16-addf-27480ef34da0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""107fcf61-6aa9-4d03-98ab-f0a1890ad7b5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Solution"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Mouse = m_Player.FindAction("Mouse", throwIfNotFound: true);
        m_Player_Solution = m_Player.FindAction("Solution", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Mouse;
    private readonly InputAction m_Player_Solution;
    public struct PlayerActions
    {
        private @InputControls m_Wrapper;
        public PlayerActions(@InputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Mouse => m_Wrapper.m_Player_Mouse;
        public InputAction @Solution => m_Wrapper.m_Player_Solution;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Mouse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @Solution.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSolution;
                @Solution.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSolution;
                @Solution.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSolution;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Solution.started += instance.OnSolution;
                @Solution.performed += instance.OnSolution;
                @Solution.canceled += instance.OnSolution;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMouse(InputAction.CallbackContext context);
        void OnSolution(InputAction.CallbackContext context);
    }
}
