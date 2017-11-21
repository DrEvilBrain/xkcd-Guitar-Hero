using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Multiplier : MonoBehaviour {

    Text multiplierBox;
    public static int multiplier;

	// Use this for initialization
	void Start ()
    {
        multiplierBox = this.gameObject.GetComponent<Text>();
        multiplier = 1;
	}

    // Update is called once per frame
    void Update ()
    {
        if (Combo.comboNum == 0)
        {
            multiplierBox.text = "x1";
            multiplierBox.color = new Color32(0, 0, 0, 255);
            multiplier = 1;
        }
        else if (Combo.comboNum >= 10 && Combo.comboNum < 20)
        {
            multiplierBox.text = "x2";
            multiplierBox.color = new Color32(186, 123, 22, 255);
            multiplier = 2;
        }
        else if (Combo.comboNum >= 20 && Combo.comboNum < 30)
        {
            multiplierBox.text = "x3";
            multiplierBox.color = new Color32(45, 189, 70, 255);
            multiplier = 3;
        }
        else if (Combo.comboNum >= 30)
        {
            multiplierBox.text = "x4";
            multiplierBox.color = new Color32(171, 49, 214, 255);
            multiplier = 4;
        }      
    }
}
