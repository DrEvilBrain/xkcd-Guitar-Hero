using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNoteInvisible : MonoBehaviour {

    Renderer[] allRenderers;

	// Use this for initialization
	void Start ()
    {
        allRenderers = GetComponentsInChildren<Renderer>();
        foreach(Renderer noteRenderer in allRenderers)
        {
            noteRenderer.enabled = false;
        }
	}
	
}