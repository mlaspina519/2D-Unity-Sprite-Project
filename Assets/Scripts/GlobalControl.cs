using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {
    public static GlobalControl Instance;
    public new string name;
    public int score = 9;

	// Use this for initialization
	void Awake () {
		if(Instance == null) {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        } else {
            Destroy(gameObject);
        }
	}
	
    public void setName(string n) {
        name = n;
    }

    public string getName() {
        return name;
    }
    
    public void setScore(int n) {
        score -= n;
    }

    public void setScore() {
        setScore(1);
    }

    public int getScore() {
        return score;
    }
}
