using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat_controller_2 : MonoBehaviour {

    private int counter = 0;
    private char[] Sequence = new char[] { 'S', 'L', 'Q', 'P' };
    Dictionary<KeyCode, char> characterTyped = new Dictionary<KeyCode, char>();

    private Animator heartAnimations;
    private GameObject heart;

    void Start ()
    { 
        heart = this.gameObject;
        heartAnimations = this.GetComponent<Animator>();
    
        characterTyped.Add(KeyCode.S, 'S');
        characterTyped.Add(KeyCode.L, 'L');
        characterTyped.Add(KeyCode.Q, 'Q');
        characterTyped.Add(KeyCode.P, 'P');
    }

    void Update()
    {
        foreach (KeyCode vkey in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(vkey))
            {
                Debug.Log(vkey.ToString());

                //correct
                if (characterTyped.ContainsKey(vkey) && characterTyped[vkey] == Sequence[counter])
                {               
                        if (Input.GetKeyDown(KeyCode.S)) S();
                        if (Input.GetKeyDown(KeyCode.L)) L();
                        if (Input.GetKeyDown(KeyCode.Q)) Q();
                        if (Input.GetKeyDown(KeyCode.P)) P();
                        counter++;
                    
                    if (counter == Sequence.Length)
                    {
                    Invoke("HeartReset", 0.5f);
                    }

                    Debug.Log("Dit is correct " + vkey.ToString());
                }
                //Wrong
                else
                {
                    Debug.Log("Dat was niet correct " + vkey.ToString());
                }
            }
        }
        
	}


    void HeartReset()
    {
        counter = 0;
        heartAnimations.SetBool("sIsTrue", false);
        heartAnimations.SetBool("LIsTrue", false);
        heartAnimations.SetBool("qIsTrue", false);
        heartAnimations.SetBool("pIsTrue", false);
    }


    void S ()
    {
        heartAnimations.SetBool("sIsTrue", true);
        
    }

    void L()
    {
        heartAnimations.SetBool("LIsTrue", true);
        
    }

    void Q()
    {
        heartAnimations.SetBool("qIsTrue", true);
        
    }

    void P()
    {
        heartAnimations.SetBool("pIsTrue", true);
        
    }
}
