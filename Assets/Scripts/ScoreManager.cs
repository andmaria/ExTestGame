using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ScoreManager : MonoBehaviour
{
    public GameObject part;
    private void Start()
    {
        part.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                part.SetActive(true);
                Destroy(gameObject, 0.3f);
        }
     }
}
