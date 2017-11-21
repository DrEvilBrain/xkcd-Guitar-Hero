using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackroundAnimation : MonoBehaviour {

    public Image image;
    public Sprite[] anim;
    public float time;

    // Use this for initialization
    void Start()
    {
        image = this.GetComponent<Image>();
        InvokeRepeating("PlayAnim", 0.5f, time);
    }

    void PlayAnim()
    {
        if(image.sprite == anim[0])
        {
            image.sprite = anim[1];
        }
        else
        {
            image.sprite = anim[0];
        }
    }
}