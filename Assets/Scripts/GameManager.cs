using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text score;
    public GameObject panelWin;
    PlayerScore PlayerSub;
    public void OnPl(int newcoin) => score.text = newcoin.ToString();
    void Start()
    { 
        PlayerSub = FindObjectOfType<PlayerScore>();
        panelWin.SetActive(false);
        PlayerSub.TrgOn += OnPl;
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
            PlayerSub.TrgOn -= OnPl;
        }
    }
}
