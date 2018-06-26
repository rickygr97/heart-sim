using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class note : MonoBehaviour {


    Rigidbody2D rb;

    public static int speed =100 ;

    spawnings spwns;
    spawningq spwnq;
    spawningl spwnl;
    spawningp spwnp;



	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(speed == 120)
        {
            spwns.spwnspeed = 5;
            spwnq.spwnspped = 5;
            spwnl.spwnspeed = 5;
            spwnp.spwnsppedd = 5;


        }
        if(speed == 150)
        {
            spwns.spwnspeed = 4;
            spwnq.spwnspped = 4;
            spwnl.spwnspeed = 4;
            spwnp.spwnsppedd = 4;
        }
        if (speed == 160)
        {
            spwns.spwnspeed = 3;
            spwnq.spwnspped = 3;
            spwnl.spwnspeed = 3;
            spwnp.spwnsppedd = 3;
        }
        if (speed == 200)
        {
            spwns.spwnspeed = 2;
            spwnq.spwnspped = 2;
            spwnl.spwnspeed = 2;
            spwnp.spwnsppedd = 2;
        }
    }
}
