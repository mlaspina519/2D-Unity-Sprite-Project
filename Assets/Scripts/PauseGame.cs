using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
    bool isPaused = false;

	public void PauseResume() {
        if (!isPaused) {
            Debug.Log("Paused");
            Time.timeScale = 0;
            isPaused = true;
        } else {
            Time.timeScale = 1;
            Debug.Log("Resumed");
            isPaused = false;
          }
    }
}
