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
         //= (pl.position + offset)*Time.deltaTime;
        Camera.main.transform.position = Vector3.Lerp(transform.position, pl.transform.position+offset, speed * Time.deltaTime);
    }
}
