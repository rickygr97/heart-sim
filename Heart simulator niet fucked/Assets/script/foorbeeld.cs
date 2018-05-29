using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foorbeeld : MonoBehaviour {

     int counter = 0;
    private char[] Sequence = new char[]{ 's', 'l', 'q', 'p' };


	void Update () {
		
	}

    private void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            if(e.character == Sequence[counter])
            {
                Debug.Log("correct" + e.character);
                if(counter < Sequence.Length-1)
                {
                    counter++;
                    Debug.Log("arraylengh" + Sequence.Length + ",counter:" + counter);

                }
                else
                {
                    counter = 0;
               //     Debug.Log(
                }
            }
        }
    }
}
