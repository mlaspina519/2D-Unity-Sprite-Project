﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateName : MonoBehaviour {
    public Text text;

	// Use this for initialization
	void Start () {
        text.text = GlobalControl.Instance.getName();
	}
}
