using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Helicopter : MonoBehaviour
{
    public float speed = 1f;
    PlayerInput playerControls;
    Vector3 dir = new Vector3();
    private int updateskip = 2;
    private int curupdate = 0;
    // Start is called before the first frame update
    void Awake()
    {
        playerControls = new PlayerInput();
    }
    public void Move(InputAction.CallbackContext context)
    {
        Vector2 inputMovement = context.ReadValue<Vector2>();
        dir = new Vector3(inputMovement.x *speed, inputMovement.y*speed, 0);    
    }
    private void FixedUpdate()
    {
        if (curupdate < updateskip)
        {
            curupdate++;
        }
        else
        {
            transform.position += dir;
            curupdate = 0;
        }
        
    }
}
