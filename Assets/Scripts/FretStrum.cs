using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FretStrum : MonoBehaviour {

    private bool fretRaised;
    private bool holdStrummed;
    public GameObject fret;
    public static bool strum;
    public static int giveHealth; //-1 to lose health, 0 for no modification, 1 to give health
    public static bool longHold;
    private bool collision;

    // Start is called just before any of the Update methods is called the first time
    private void Start()
    {
        strum = false;
        holdStrummed = false;
        collision = false;
        fret = this.gameObject;
        giveHealth = 0;
    }

    // Update is called once per frame
    void Update ()
    {
        if (fret.name == "Green Fret")
        {
            fretRaised = FretboardControl.greenRaised;
        }
        else if (fret.name == "Red Fret")
        {
            fretRaised = FretboardControl.redRaised;
        }
        else if (fret.name == "Yellow Fret")
        {
            fretRaised = FretboardControl.yellowRaised;
        }
        else if (fret.name == "Blue Fret")
        {
            fretRaised = FretboardControl.blueRaised;
        }
        else if (fret.name == "Orange Fret")
        {
            fretRaised = FretboardControl.orangeRaised;
        }

        if(Health.gaveHealth == true)
        {
            giveHealth = 0;
        } 
    }

    private void LateUpdate()
    {
        if (Input.GetButtonDown("Strum"))
        {
            strum = true;
            if (collision == false)
            {
                giveHealth = -1;
            }
        }
        else if (fretRaised == false)
        {
            holdStrummed = false;
            longHold = false;
        }
        else
        {
            strum = false;
        }
    }

    // OnTriggerStay is called once per frame for every Collider other that is touching the trigger
    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "Note" && fretRaised == true && strum == true) //standard notes
        {
            Destroy(collider.gameObject);
            giveHealth = 1;
            collision = true;
        }
        else if (collider.gameObject.tag == "Hold Note Start" && fretRaised == true && strum == true) //hold note starts
        {
            Destroy(collider.gameObject);
            holdStrummed = true;
            giveHealth = 1;
            collision = true;
        }
        else if (collider.gameObject.tag == "Hold Note" && fretRaised == true && holdStrummed == true) //hold note trails
        {
            Destroy(collider.gameObject);
            longHold = true;
            collision = true;
        }
        else
        {
            collision = false;
        }
    }

}