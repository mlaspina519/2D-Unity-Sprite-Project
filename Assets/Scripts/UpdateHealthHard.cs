using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHealthHard : MonoBehaviour {
    public Text enemyHealth;
    public Text playerHealth;
    public PlayerController player;
    public EnemyFollow enemy;

    void Update() {
        if(player != null) {
            playerHealth.text = player.Health.ToString();
        } else {
            playerHealth.text = "0";
        }

        if (enemy != null) {
            enemyHealth.text = enemy.Health.ToString();
        } else {
            enemyHealth.text = "0";
        }
    }
}