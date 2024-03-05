using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;


public class HandController : MonoBehaviour
{
    public InputActionReference triggerAction;
    public InputActionReference gripAction;
    public Hand hand;

    void Start()
    {
        triggerAction.action.Enable();
        gripAction.action.Enable();
    }

    void Update()
    {
        triggerAction.action.performed += ctx => {OnTrigger(ctx);};
        gripAction.action.performed += ctx => {OnGrip(ctx);};
    }

    private void OnGrip(InputAction.CallbackContext context)
    {
        hand.SetGrip(gripAction.action.ReadValue<float>());
    }

    private void OnTrigger(InputAction.CallbackContext context)
    {
        hand.SetTrigger(triggerAction.action.ReadValue<float>());
    }
}
