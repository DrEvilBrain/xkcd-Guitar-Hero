using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FretboardControl : MonoBehaviour
{

    static public bool greenRaised;
    static public bool redRaised;
    static public bool yellowRaised;
    static public bool blueRaised;
    static public bool orangeRaised;

    public GameObject greenFret;
    public GameObject redFret;
    public GameObject yellowFret;
    public GameObject blueFret;
    public GameObject orangeFret;

    public float raise;

    // Use this for initialization
    void Start()
    {
        greenRaised = false;
        redRaised = false;
        yellowRaised = false;
        blueRaised = false;
        orangeRaised = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Green Fret") && greenRaised == false)
        {
            greenRaised = true;
            greenFret.transform.Translate(0, raise, 0);
        }
        if(Input.GetButtonDown("Red Fret") && redRaised == false)
        {
            redRaised = true;
            redFret.transform.Translate(0, raise, 0);
        }
        if(Input.GetButtonDown("Yellow Fret") && yellowRaised == false)
        {
            yellowRaised = true;
            yellowFret.transform.Translate(0, raise, 0);
        }
        if(Input.GetButtonDown("Blue Fret") && blueRaised == false)
        {
            blueRaised = true;
            blueFret.transform.Translate(0, raise, 0);
        }
        if(Input.GetButtonDown("Orange Fret") && orangeRaised == false)
        {
            orangeRaised = true;
            orangeFret.transform.Translate(0, raise, 0);
        }

        if(Input.GetButtonUp("Green Fret") && greenRaised == true)
        {
            greenRaised = false;
            greenFret.transform.Translate(0, -raise, 0);
        }
        if (Input.GetButtonUp("Red Fret") && redRaised == true)
        {
            redRaised = false;
            redFret.transform.Translate(0, -raise, 0);
        }
        if (Input.GetButtonUp("Yellow Fret") && yellowRaised == true)
        {
            yellowRaised = false;
            yellowFret.transform.Translate(0, -raise, 0);
        }
        if (Input.GetButtonUp("Blue Fret") && blueRaised == true)
        {
            blueRaised = false;
            blueFret.transform.Translate(0, -raise, 0);
        }
        if (Input.GetButtonUp("Orange Fret") && orangeRaised == true)
        {
            orangeRaised = false;
            orangeFret.transform.Translate(0, -raise, 0);
        }
    }

}