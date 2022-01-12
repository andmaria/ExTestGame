using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score;
    public GameObject panelWin;
    void Start()
    {
        panelWin.SetActive(false);
    }
    void FixedUpdate()
    {
        score.text = ScoreManager.score.ToString();
    }
    public void RestartScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            panelWin.SetActive(true);
            PlayerControl.gameEnd = true;
        }
    }
}
