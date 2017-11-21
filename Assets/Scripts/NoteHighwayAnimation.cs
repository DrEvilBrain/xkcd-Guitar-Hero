using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteHighwayAnimation : MonoBehaviour {

    public float speed;
    private float movement;

    public GameObject notehighway;

    // Start is called just before any of the Update methods is called the first time
    private void Start()
    {
        notehighway = this.gameObject;
    }

    // Update is called once per frame
    void Update ()
    {
        movement = Time.time * speed;
        notehighway.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, movement);
	}
}