using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour {
    public void ExitGame() {
        Application.Quit();
    }

    public void StartGame() {
        SceneManager.LoadScene("Easy");
    }

    public void ReturnToMenu() {
        SceneManager.LoadScene("Menu");
    }

    public void OpenRules() {
        SceneManager.LoadScene("Rules");
    }

    public void OpenSettings() {
        SceneManager.LoadScene("Settings");
    }
}