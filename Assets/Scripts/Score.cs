using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    Text scoreBox;
    private int scoreNum;
    private string scoreString;

	// Use this for initialization
	void Start ()
    {
        scoreBox = this.gameObject.GetComponent<Text>();
        scoreNum = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(FretStrum.giveHealth == 1)
        {
            scoreNum += 100 * Multiplier.multiplier;
        }
        if(FretStrum.longHold == true)
        {
            scoreNum += 1 * Multiplier.multiplier;
        }

        scoreString = scoreNum.ToString("000000");
        scoreBox.text = scoreString;
    }
}
