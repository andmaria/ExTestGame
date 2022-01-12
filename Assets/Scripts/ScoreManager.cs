using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject part;
    public static int score;
    // Start is called before the first frame update
    private void Start()
    {
        part.SetActive(false);
        score = 0;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            score++;
            part.SetActive(true);
            Destroy(gameObject,0.3f);
        }
    }
}
