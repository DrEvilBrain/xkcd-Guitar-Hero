using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SongEnd : MonoBehaviour {

    public GameObject songEnder;
    public Image win;
    public Image lose;
    public AudioSource music;

    // Use this for initialization
    void Start ()
    {
        songEnder = this.gameObject;
        win = GameObject.Find("You Rock").GetComponent<Image>();
        lose = GameObject.Find("Song Failed").GetComponent<Image>();
        win.enabled = false;
        lose.enabled = false;
    }

    void Update()
    {
        if(Health.health == 0)
        {
            lose.enabled = true;
            Time.timeScale = 0;
            music.Stop();
        }

        if(Input.GetButtonDown("Submit"))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Menu");
        }
    }

    // OnTriggerEnter is called when the Collider note enters the notevisible wall
    private void OnTriggerExit(Collider end)
    {
        if(end.gameObject.name == "End of Song")
        {
            win.enabled = true;
            Time.timeScale = 0;
            music.Stop();
        }
    }
}
