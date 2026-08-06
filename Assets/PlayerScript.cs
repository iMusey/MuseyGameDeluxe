using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScript : MonoBehaviour
{
    public Vector2 moveVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((new Vector3(moveVal.x, moveVal.y, 0)).normalized*Time.deltaTime);
    }
    public void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("fire");
    }
    public void Move(InputAction.CallbackContext context)
    {
        Debug.Log(context.control);
        moveVal = context.ReadValue<Vector2>();
    }
}
