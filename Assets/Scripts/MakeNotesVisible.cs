using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeNotesVisible : MonoBehaviour {

    public GameObject notevisible;

	// Use this for initialization
	void Start ()
    {
        notevisible = this.gameObject;
	}

    // OnTriggerEnter is called when the Collider note enters the notevisible wall
    private void OnTriggerExit(Collider note)
    {
        note.gameObject.GetComponent<Renderer>().enabled = true;
    }

}