using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerControl : MonoBehaviour
{
    public float movementSpeed = 3;
    Rigidbody rb;
    public Animator anim;
    private bool runCheck;
    public static bool gameEnd;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        gameEnd = false;
    }

    private void Update()
    {
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
            float aa = Input.GetAxis("Mouse X");
            Vector3 mov = new Vector3(0f, 0f, transform.position.z) * movementSpeed;
            mov = Vector3.ClampMagnitude(mov, movementSpeed);
            transform.Translate(aa, 0, 0f);
            transform.Translate(mov * Time.deltaTime * movementSpeed);
            anim.Play("a_Running");
        }
        else 
        {
            anim.Play("a_Idle");
        }
    }
}
