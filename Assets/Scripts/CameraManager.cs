using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform pl;
    public Vector3 offset;
    float speed = 5;
    private void Update()
    {
        
        Camera.main.transform.position = Vector3.Lerp(transform.position, pl.transform.position+offset, speed * Time.deltaTime);
    }
}
