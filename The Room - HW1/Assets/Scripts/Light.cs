using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class Lights : MonoBehaviour
{
    public Light light;
    public InputActionReference lightsAction;
    Color cyan = new Color(0,1,1,1);

    void Start()
    {
        light = GetComponent<Light>();
        lightsAction.action.performed += ctx => {OnSelect(ctx);};

    }

    private void OnSelect(InputAction.CallbackContext context)
    {
        Debug.Log("Button pressed");
        Debug.Log(light.color);
        if (light.color == Color.white)
        {
            light.color = cyan;
        }
        else 
        {
            light.color = Color.white;
        }
    }

    public void OnEnable()
    {
        lightsAction.action.Enable();
    }

    public void OnDisable()
    {
        lightsAction.action.Disable();
    }
}