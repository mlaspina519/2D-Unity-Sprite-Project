using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour {
    public Text text;

    // Use this for initialization
    void Start() {
        text.text = GlobalControl.Instance.getScore().ToString();
    }

    void Update() {
        text.text = GlobalControl.Instance.getScore().ToString();
    }
}
