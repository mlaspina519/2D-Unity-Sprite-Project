using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour {
    public GlobalControl control;
    public InputField input;

	public void SetPlayerName() {
        control.setName(input.text);
    }
}
