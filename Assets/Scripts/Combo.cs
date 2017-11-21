using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour {

    Text comboBox;
    static public int comboNum;
    private string comboString;
    private bool[] frets;
    private int numFrets;

	// Use this for initialization
	void Start ()
    {
        comboBox = this.gameObject.GetComponent<Text>();
        comboNum = 0;
        numFrets = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        numFrets = 0;

		if(FretStrum.giveHealth == 1)
        {
            frets = new bool[5] { FretboardControl.greenRaised, FretboardControl.redRaised, FretboardControl.yellowRaised, FretboardControl.blueRaised, FretboardControl.orangeRaised };

            for (int i = 0; i < 5; i++)
            {
                if(frets[i] == true)
                {
                    numFrets += 1;
                }
            }

            comboNum += numFrets;
        }
        else if(FretStrum.giveHealth == -1 || MissedNotes.comboBreaker == true)
        {
            comboNum = 0;
        }

        comboString = comboNum.ToString("000");
        comboBox.text = comboString;
	}
}
