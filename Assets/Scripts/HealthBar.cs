using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public GameObject healthBar;
    private float health;
    private float healthOld;
    private float healthLerp;

    // Start is called just before any of the Update methods is called the first time
    private void Start()
    {
        healthBar = this.gameObject;
        health = 50;
    }

    // Update is called once per frame
    void Update()
    {
        healthOld = health;
        health = Health.health;

        if(health != healthOld)
        {
            float healthChange = healthOld - health;
            transform.Rotate(Vector3.forward * healthChange, Space.Self);
        }
    }

}