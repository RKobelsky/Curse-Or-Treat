using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    
    public TMP_Text pointsText;

    public void Setup(int score) {
        gameObject.SetActive(true);
        pointsText.text = "DISTANCE: " + score.ToString() + "m";
    }

    public void RestartButton() {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton() {
        SceneManager.LoadScene("Menu");
        MenuMusic.instance.GetComponent<AudioSource>().Play();
    }
}