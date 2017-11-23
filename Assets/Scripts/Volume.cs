﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour {
    public Slider slider;

    void Start() {
        slider = GetComponent<Slider>();
    }

    public void OnValueChanged() {
        AudioListener.volume = slider.value;
    }
}