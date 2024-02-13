//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Controllers.inputactions
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

public partial class @Controllers: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controllers()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controllers"",
    ""maps"": [
        {
            ""name"": ""Right controller"",
            ""id"": ""400022f2-2e68-4eb0-9341-845f17fcbb77"",
            ""actions"": [
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""dc7450f6-6ea9-450d-8de1-da03577f9949"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Lights"",
                    ""type"": ""Button"",
                    ""id"": ""b38459a1-e159-4965-bf21-7776b8a4285a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f12f55f-b4c0-4002-8d18-b5e409a7ee55"",
                    ""path"": ""<XRController>{RightHand}/{PrimaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""241da3cb-dc2d-490c-9dc1-cd02cf74fa4e"",
                    ""path"": ""<XRController>{RightHand}/{SecondaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lights"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Left controller"",
            ""id"": ""345799a9-9170-4ec3-ad09-64277827a7ef"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""650dc638-9c1d-4b9f-a80c-6936568e99ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a705fbf-d0e5-4dec-88ab-c35bd883d66c"",
                    ""path"": ""<XRController>{LeftHand}/{PrimaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Right controller
        m_Rightcontroller = asset.FindActionMap("Right controller", throwIfNotFound: true);
        m_Rightcontroller_Quit = m_Rightcontroller.FindAction("Quit", throwIfNotFound: true);
        m_Rightcontroller_Lights = m_Rightcontroller.FindAction("Lights", throwIfNotFound: true);
        // Left controller
        m_Leftcontroller = asset.FindActionMap("Left controller", throwIfNotFound: true);
        m_Leftcontroller_Move = m_Leftcontroller.FindAction("Move", throwIfNotFound: true);
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

    // Right controller
    private readonly InputActionMap m_Rightcontroller;
    private List<IRightcontrollerActions> m_RightcontrollerActionsCallbackInterfaces = new List<IRightcontrollerActions>();
    private readonly InputAction m_Rightcontroller_Quit;
    private readonly InputAction m_Rightcontroller_Lights;
    public struct RightcontrollerActions
    {
        private @Controllers m_Wrapper;
        public RightcontrollerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Quit => m_Wrapper.m_Rightcontroller_Quit;
        public InputAction @Lights => m_Wrapper.m_Rightcontroller_Lights;
        public InputActionMap Get() { return m_Wrapper.m_Rightcontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightcontrollerActions set) { return set.Get(); }
        public void AddCallbacks(IRightcontrollerActions instance)
        {
            if (instance == null || m_Wrapper.m_RightcontrollerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RightcontrollerActionsCallbackInterfaces.Add(instance);
            @Quit.started += instance.OnQuit;
            @Quit.performed += instance.OnQuit;
            @Quit.canceled += instance.OnQuit;
            @Lights.started += instance.OnLights;
            @Lights.performed += instance.OnLights;
            @Lights.canceled += instance.OnLights;
        }

        private void UnregisterCallbacks(IRightcontrollerActions instance)
        {
            @Quit.started -= instance.OnQuit;
            @Quit.performed -= instance.OnQuit;
            @Quit.canceled -= instance.OnQuit;
            @Lights.started -= instance.OnLights;
            @Lights.performed -= instance.OnLights;
            @Lights.canceled -= instance.OnLights;
        }

        public void RemoveCallbacks(IRightcontrollerActions instance)
        {
            if (m_Wrapper.m_RightcontrollerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRightcontrollerActions instance)
        {
            foreach (var item in m_Wrapper.m_RightcontrollerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RightcontrollerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RightcontrollerActions @Rightcontroller => new RightcontrollerActions(this);

    // Left controller
    private readonly InputActionMap m_Leftcontroller;
    private List<ILeftcontrollerActions> m_LeftcontrollerActionsCallbackInterfaces = new List<ILeftcontrollerActions>();
    private readonly InputAction m_Leftcontroller_Move;
    public struct LeftcontrollerActions
    {
        private @Controllers m_Wrapper;
        public LeftcontrollerActions(@Controllers wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Leftcontroller_Move;
        public InputActionMap Get() { return m_Wrapper.m_Leftcontroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftcontrollerActions set) { return set.Get(); }
        public void AddCallbacks(ILeftcontrollerActions instance)
        {
            if (instance == null || m_Wrapper.m_LeftcontrollerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LeftcontrollerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(ILeftcontrollerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(ILeftcontrollerActions instance)
        {
            if (m_Wrapper.m_LeftcontrollerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILeftcontrollerActions instance)
        {
            foreach (var item in m_Wrapper.m_LeftcontrollerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LeftcontrollerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LeftcontrollerActions @Leftcontroller => new LeftcontrollerActions(this);
    public interface IRightcontrollerActions
    {
        void OnQuit(InputAction.CallbackContext context);
        void OnLights(InputAction.CallbackContext context);
    }
    public interface ILeftcontrollerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
