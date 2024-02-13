using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public GameObject player;
    public GameObject plane;
    public InputActionReference moveAction;
    private Vector3 startPosition;
    private Vector3 endPosition;

    private bool move = false;

    void Start()
    {
        moveAction.action.performed += ctx => {OnSelect(ctx);};
        startPosition = player.transform.position;
        endPosition = new Vector3(plane.transform.position.x,
                                plane.transform.position.y + 2,
                                plane.transform.position.z);
        Debug.Log(startPosition);
    }

    private void OnSelect(InputAction.CallbackContext context)
    {
        Debug.Log("Button pressed");
        Debug.Log(player.transform.position);
        if (!move)
        {
            player.transform.position = endPosition;
            move = true;
        }
        else 
        {
            player.transform.position = startPosition;
            move = false;
        }
    }

    public void OnEnable()
    {
        moveAction.action.Enable();
    }

    public void OnDisable()
    {
        moveAction.action.Disable();
    }
}