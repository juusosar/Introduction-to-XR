using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class Lights : MonoBehaviour
{
    public Light _light;
    public InputActionReference lightsAction;
    Color cyan = new Color(0,1,1,1);

    void Start()
    {
        _light = GetComponent<Light>();
        lightsAction.action.performed += ctx => {OnSelect(ctx);};

    }

    private void OnSelect(InputAction.CallbackContext context)
    {
        Debug.Log("Button pressed");
        Debug.Log(GetComponent<Light>().color);
        if (_light.color == Color.white)
        {
            _light.color = cyan;
        }
        else 
        {
            _light.color = Color.white;
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