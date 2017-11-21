using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    static public int health;
    static public bool gaveHealth;

	// Use this for initialization
	void Start ()
    {
        health = 50;
        gaveHealth = false;
	}

    // Update is called once per frame
    void Update()
    {
        gaveHealth = false;

        if(health <= 0)
        {
            health = 0;
        }
        if (FretStrum.strum == true && FretStrum.giveHealth == -1 && health != 0)
        {
            health -= 2;
            gaveHealth = true;
        }
        if(FretStrum.strum == true && FretStrum.giveHealth == 1 && health < 100 && health != 0)
        {
            health += 2;
            gaveHealth = true;
        }  
	}
}
