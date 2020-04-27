// GENERATED AUTOMATICALLY FROM 'Assets/Actors/PlayerInput/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""cbae9aec-c74e-43d8-91c8-d0ffde4f4c22"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e0b369f0-dbb7-4977-aeb6-2483388962ed"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""9596a4b1-de89-4ca6-ba1d-146164e60dc9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""8113b60e-21fe-46b8-a2f0-d94b92653e10"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Special"",
                    ""type"": ""Button"",
                    ""id"": ""e0237e9b-04fe-43c4-a686-1e8681bbd076"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4c1d0488-a0a2-4ecc-806e-824d17747b9e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""663bb479-058b-40bb-9897-4a1dec1144d5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15c37089-870e-46e1-b166-497e87e87279"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d7ef24b-9eeb-462d-9576-723ee96e0127"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25e49618-93f9-4661-a095-f99469e45671"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.3)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyboardTFGH"",
                    ""id"": ""f79e308d-36ae-4212-b962-731bd4659286"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5628e8c6-0020-48aa-bf05-0526967ba51e"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""30bb506f-de64-4621-8800-02006580f9f0"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7e1c5ea-dd64-4c42-a16e-d0dbcf2b9c2d"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0a530203-7f8a-4def-8fc1-72864d21acbb"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyboardArrows"",
                    ""id"": ""2190546c-908c-4e8e-abfa-953ac7efcc11"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6936b4ac-df5b-481c-98e3-324b3aad44c7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6e96d8b1-7e26-465e-adf8-b3a579676b3a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73c94a31-50cc-4cf9-95e8-3634dd477cce"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""89f34d7f-b53b-4f5d-8f31-b87884ab6d10"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""edc42df9-19da-4696-84ba-dac79bba88ea"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyboardWASD"",
                    ""id"": ""c207dc39-04e3-4938-8c93-31f9c10fec98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0bf5406e-47d4-4bdd-a8f1-d93d07087ec9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""37e2ebb6-be2a-4605-9456-51b2cd1a9b9c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b96cd41f-6aad-4eac-8831-34e15a31070c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""739abc31-b561-4d13-8e91-817c72b8d0a3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyboardIJKL"",
                    ""id"": ""c96822f1-f0a7-45f0-9dc8-9a4d1f2a260c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""76e934b6-67dc-45f1-9757-de85b20ab3bd"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9d72a053-6506-47a8-a01d-17862ac4b4fa"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d81bd1c8-1d43-4faf-918e-1799b096a3ff"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6345c37d-5245-4818-9af7-489c18caf8dc"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""12dc62d4-de59-4997-bad4-12f1698a7d9a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fde5f21-4c4c-4e90-8003-ca4aa79d7051"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aafffb1d-fd0a-45e4-8bf2-ade7e18e5d57"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2bd63052-6e26-4709-a3b4-40e023b458d5"",
                    ""path"": ""<Keyboard>/rightAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Special"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Selection Controls"",
            ""id"": ""ea48a53b-6f0c-4eb3-8cfc-60ca2651f4ac"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Value"",
                    ""id"": ""4bad7d49-3c9e-4a25-a7fa-7ba05a4932df"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""1e5c43d8-1a4f-4687-8e60-a2e92c226d5b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AssignKeyboard"",
                    ""type"": ""Button"",
                    ""id"": ""f39022cf-98c9-4777-991f-898a1c87dcbd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f987d369-f114-4eb1-a72c-37fd01dd6f9b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72b8305c-15a1-4eb4-a156-dbb38ea0c82e"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b19a875-4066-420a-ba47-0486bd3a6c81"",
                    ""path"": ""<Keyboard>/rightAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b70b874-5a63-4b2c-838d-377ad318543c"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c35928ba-eee7-411c-8cbf-818df0080c84"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15098700-d8e0-4f45-b294-d3f87616c072"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c564d37a-f6af-4d44-aea0-6dc86e2f61f9"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c7d680b-ab62-4369-9116-79f26a5a0841"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f672cb82-d5fd-4c6e-a115-20c9ff0906b0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e169f8f5-4d36-4db6-a655-c828bb428222"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a62114a2-55ea-45ac-a55f-66a1b7046857"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90258115-126e-4e7f-8be7-8a9b487c0c0b"",
                    ""path"": ""<Keyboard>/rightAlt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD;Gamepad"",
                    ""action"": ""AssignKeyboard"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3311ed53-f446-47c6-9f4c-dfc8d04406b8"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1abe7389-89c1-4e6d-9d15-2345881c3115"",
                    ""path"": ""2DVector(normalize=false)"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ee2b1e1b-5bd1-4ca1-ae83-c0e21f53abfa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e909cf78-99c8-4ad3-9d07-bc888562a6ea"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ffae3bfd-5c26-4288-ad6a-b61afbb9e2ff"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ce88ea46-67a8-49e9-a757-52faf6f58f9c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardWASD"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2450140b-4f89-43ef-a74b-5c7ba2e5e6d3"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b0ceaba1-79ec-4abe-bb9d-f41584be7a21"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fc6c99cf-de20-4065-9a5a-6e470bf0f90c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""25d45934-15c0-421e-ba65-236045879545"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4df848b9-7a9f-4146-8e6c-6b17b9a47e7a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardIJKL"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        },
        {
            ""name"": ""KeyboardWASD"",
            ""bindingGroup"": ""KeyboardWASD"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyboardIJKL"",
            ""bindingGroup"": ""KeyboardIJKL"",
            ""devices"": []
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_Aim = m_PlayerControls.FindAction("Aim", throwIfNotFound: true);
        m_PlayerControls_Fire = m_PlayerControls.FindAction("Fire", throwIfNotFound: true);
        m_PlayerControls_Special = m_PlayerControls.FindAction("Special", throwIfNotFound: true);
        // Selection Controls
        m_SelectionControls = asset.FindActionMap("Selection Controls", throwIfNotFound: true);
        m_SelectionControls_Select = m_SelectionControls.FindAction("Select", throwIfNotFound: true);
        m_SelectionControls_Confirm = m_SelectionControls.FindAction("Confirm", throwIfNotFound: true);
        m_SelectionControls_AssignKeyboard = m_SelectionControls.FindAction("AssignKeyboard", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_Aim;
    private readonly InputAction m_PlayerControls_Fire;
    private readonly InputAction m_PlayerControls_Special;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @Aim => m_Wrapper.m_PlayerControls_Aim;
        public InputAction @Fire => m_Wrapper.m_PlayerControls_Fire;
        public InputAction @Special => m_Wrapper.m_PlayerControls_Special;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnFire;
                @Special.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSpecial;
                @Special.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSpecial;
                @Special.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnSpecial;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Special.started += instance.OnSpecial;
                @Special.performed += instance.OnSpecial;
                @Special.canceled += instance.OnSpecial;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // Selection Controls
    private readonly InputActionMap m_SelectionControls;
    private ISelectionControlsActions m_SelectionControlsActionsCallbackInterface;
    private readonly InputAction m_SelectionControls_Select;
    private readonly InputAction m_SelectionControls_Confirm;
    private readonly InputAction m_SelectionControls_AssignKeyboard;
    public struct SelectionControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public SelectionControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_SelectionControls_Select;
        public InputAction @Confirm => m_Wrapper.m_SelectionControls_Confirm;
        public InputAction @AssignKeyboard => m_Wrapper.m_SelectionControls_AssignKeyboard;
        public InputActionMap Get() { return m_Wrapper.m_SelectionControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SelectionControlsActions set) { return set.Get(); }
        public void SetCallbacks(ISelectionControlsActions instance)
        {
            if (m_Wrapper.m_SelectionControlsActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnSelect;
                @Confirm.started -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnConfirm;
                @AssignKeyboard.started -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnAssignKeyboard;
                @AssignKeyboard.performed -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnAssignKeyboard;
                @AssignKeyboard.canceled -= m_Wrapper.m_SelectionControlsActionsCallbackInterface.OnAssignKeyboard;
            }
            m_Wrapper.m_SelectionControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @AssignKeyboard.started += instance.OnAssignKeyboard;
                @AssignKeyboard.performed += instance.OnAssignKeyboard;
                @AssignKeyboard.canceled += instance.OnAssignKeyboard;
            }
        }
    }
    public SelectionControlsActions @SelectionControls => new SelectionControlsActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardWASDSchemeIndex = -1;
    public InputControlScheme KeyboardWASDScheme
    {
        get
        {
            if (m_KeyboardWASDSchemeIndex == -1) m_KeyboardWASDSchemeIndex = asset.FindControlSchemeIndex("KeyboardWASD");
            return asset.controlSchemes[m_KeyboardWASDSchemeIndex];
        }
    }
    private int m_KeyboardIJKLSchemeIndex = -1;
    public InputControlScheme KeyboardIJKLScheme
    {
        get
        {
            if (m_KeyboardIJKLSchemeIndex == -1) m_KeyboardIJKLSchemeIndex = asset.FindControlSchemeIndex("KeyboardIJKL");
            return asset.controlSchemes[m_KeyboardIJKLSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSpecial(InputAction.CallbackContext context);
    }
    public interface ISelectionControlsActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnAssignKeyboard(InputAction.CallbackContext context);
    }
}
