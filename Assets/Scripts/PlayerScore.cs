using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    int score; 
    public delegate void trg(int touchCoins);
    public event trg TrgOn;
    private void Start()
    {
        score = 0;
    }
    public void UpdateScore()
    {
        score++;
        TrgOn.Invoke(score);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sc")
        {
            UpdateScore();
        }
    }
}
