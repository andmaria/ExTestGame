using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerControl : MonoBehaviour
{
    public float movementSpeed = 20;
    Rigidbody rb;
    public Animator anim;
    private bool runCheck;
    public static bool gameEnd;
    public float sensMouse=1,speed;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        gameEnd = false;
    }
    private void Update()
    {
        speed = rb.velocity.magnitude * 3.6f;
        anim.SetFloat("Speed", speed);
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4f, 4f), transform.position.y, Mathf.Clamp(transform.position.z, 0f, 51.1f));
        if (Input.GetMouseButton(0))
        {
            runCheck = true;
            Controller(); 
        }
        else if (Input.GetMouseButtonUp(0))
        {
            runCheck = false;
        } 
    }
    public void Controller()
    {
        if (runCheck && !gameEnd)
        {
            float mouseRotate = Input.GetAxis("Mouse X")* sensMouse;
            float mov = transform.position.z;
          
            rb.AddRelativeForce(mouseRotate * movementSpeed * Vector3.right);
            rb.AddRelativeForce(Vector3.forward * movementSpeed - rb.velocity);
          
          
        }
    }
}
