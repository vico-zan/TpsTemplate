// GENERATED AUTOMATICALLY FROM 'Assets/main/Scripts/VControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VControls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @VControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VControls"",
    ""maps"": [
        {
            ""name"": ""vplay"",
            ""id"": ""265c38f5-dd18-4d34-b198-aec58e1627ff"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""50fd2809-3aa3-4a90-988e-1facf6773553"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""Value"",
                    ""id"": ""c60e0974-d140-4597-a40e-9862193067e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""confirm"",
                    ""type"": ""Button"",
                    ""id"": ""1077f913-a9f9-41b1-acb3-b9ee0adbc744"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap,SlowTap""
                },
                {
                    ""name"": ""cancel"",
                    ""type"": ""Button"",
                    ""id"": ""c7864115-0006-4da0-9cff-7c6cc1a72ef4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Tap,SlowTap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1b8c4dd-7b3a-4db6-a93a-0889b59b1afc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""cefc16fc-557a-44b0-939f-2ad792876b07"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""07244659-79df-461d-b329-defbe2fbc5f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0ec75cb-f02c-40d2-a33f-1fd6eab2ae0b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""21fe6bfe-4721-4483-9f4a-a0031ade105c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2dd39746-c75c-4a11-838a-e59eacaf4e0b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c106d6e6-2780-47ff-b318-396171bd54cc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=10,y=10)"",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""578caa03-6827-4797-adfc-a59770c437fe"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=2,y=2)"",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abb776f3-f329-4f7b-bbf8-b577d13be018"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""230dcd4e-4af3-4454-b310-ebcdac1519fa"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2628014a-85ca-4695-98ab-f4f12c46a38a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""345cd5cd-b9cd-4990-84cc-0c0196771a6b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // vplay
        m_vplay = asset.FindActionMap("vplay", throwIfNotFound: true);
        m_vplay_move = m_vplay.FindAction("move", throwIfNotFound: true);
        m_vplay_look = m_vplay.FindAction("look", throwIfNotFound: true);
        m_vplay_confirm = m_vplay.FindAction("confirm", throwIfNotFound: true);
        m_vplay_cancel = m_vplay.FindAction("cancel", throwIfNotFound: true);
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

    // vplay
    private readonly InputActionMap m_vplay;
    private IVplayActions m_VplayActionsCallbackInterface;
    private readonly InputAction m_vplay_move;
    private readonly InputAction m_vplay_look;
    private readonly InputAction m_vplay_confirm;
    private readonly InputAction m_vplay_cancel;
    public struct VplayActions
    {
        private @VControls m_Wrapper;
        public VplayActions(@VControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_vplay_move;
        public InputAction @look => m_Wrapper.m_vplay_look;
        public InputAction @confirm => m_Wrapper.m_vplay_confirm;
        public InputAction @cancel => m_Wrapper.m_vplay_cancel;
        public InputActionMap Get() { return m_Wrapper.m_vplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VplayActions set) { return set.Get(); }
        public void SetCallbacks(IVplayActions instance)
        {
            if (m_Wrapper.m_VplayActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_VplayActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_VplayActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_VplayActionsCallbackInterface.OnMove;
                @look.started -= m_Wrapper.m_VplayActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_VplayActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_VplayActionsCallbackInterface.OnLook;
                @confirm.started -= m_Wrapper.m_VplayActionsCallbackInterface.OnConfirm;
                @confirm.performed -= m_Wrapper.m_VplayActionsCallbackInterface.OnConfirm;
                @confirm.canceled -= m_Wrapper.m_VplayActionsCallbackInterface.OnConfirm;
                @cancel.started -= m_Wrapper.m_VplayActionsCallbackInterface.OnCancel;
                @cancel.performed -= m_Wrapper.m_VplayActionsCallbackInterface.OnCancel;
                @cancel.canceled -= m_Wrapper.m_VplayActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_VplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @confirm.started += instance.OnConfirm;
                @confirm.performed += instance.OnConfirm;
                @confirm.canceled += instance.OnConfirm;
                @cancel.started += instance.OnCancel;
                @cancel.performed += instance.OnCancel;
                @cancel.canceled += instance.OnCancel;
            }
        }
    }
    public VplayActions @vplay => new VplayActions(this);
    public interface IVplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
}
