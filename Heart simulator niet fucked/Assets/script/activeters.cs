using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeters : MonoBehaviour {

    public KeyCode key;

    bool active = false;


    GameObject notes;

    private note nt;

    private NoteDestroyer health;

    spawing sp;
	// Use this for initialization
	void Start () {
        nt = GetComponent<note>();
        //      sp = nt.speed;
        health = GetComponent<NoteDestroyer>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(key) && active)
        {
            Destroy(notes);

            note.speed+=5;

            highcorenummer2.AddPoints(1);
        }
        if (Input.GetKeyDown(key))
        {
            // health.health +=1;
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if(collision.gameObject.tag == "note")
        {
            notes = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        active = false;
    }
}
