using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destrot2 : MonoBehaviour {
    bool active = false;
    private NoteDestroyer health;
    GameObject notes;
    // Use this for initialization
    void Start () {
        health = GetComponent<NoteDestroyer>();
    }
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown(KeyCode.S) && active)
        {
            health.health ++;
        }
        if (Input.GetKeyDown(KeyCode.Q) && active)
        {
            health.health ++;
        }
        if (Input.GetKeyDown(KeyCode.L) && active)
        {
            health.health ++;
        }
        if (Input.GetKeyDown(KeyCode.P) && active)
        {
            health.health ++;
        }
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        active = true;
        if (collision.gameObject.tag == "note")
        {
            notes = collision.gameObject;
        }

       
    }
}
