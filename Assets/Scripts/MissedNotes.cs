using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissedNotes : MonoBehaviour {

    public GameObject missednotes;
    public static bool comboBreaker;

	// Use this for initialization
	void Start ()
    {
        missednotes = this.gameObject;
        comboBreaker = false;
	}

    private void Update()
    {
        comboBreaker = false;
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider note)
    {
        if (note.gameObject.tag == "Note" || note.gameObject.tag == "Hold Note Start")
        {
            Destroy(note.gameObject);
            Health.health -= 2;
            comboBreaker = true;
        }
        else if(note.gameObject.tag == "Hold Note Trail")
        {
            Destroy(note.gameObject);
            comboBreaker = true;
        }
    }

}