using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawing : MonoBehaviour {

    public Transform tf;

    public Transform prefab;

    public Canvas can;

    public GameObject[] arrayspawning = new GameObject[4];

    public GameObject[] spawningpoints = new GameObject[4];


   public note nt;
    

	// Use this for initialization
	void Start ()
    {
		StartCoroutine(spawning());
        //   prefab.transform.SetParent

        

	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    IEnumerator spawning()
    {

        //for (int i = 0; i < 1; i++)
        //{
        //    yield return new WaitForSeconds(2);

        //  var clone = Instantiate(arrayspawning[1],tf.transform.position, Quaternion.identity);

        //    clone.transform.SetParent(can.transform);
        //    i--;
        //}
        for (int e = 0; e < 4; e++)
        {
            yield return new WaitForSeconds(2);

            var cloneS = Instantiate(arrayspawning[e], spawningpoints[0].transform.position, Quaternion.identity);
            var cloneL = Instantiate(arrayspawning[e], spawningpoints[1].transform.position, Quaternion.identity);
            var cloneQ = Instantiate(arrayspawning[e], spawningpoints[2].transform.position, Quaternion.identity);
            var cloneP = Instantiate(arrayspawning[e], spawningpoints[3].transform.position, Quaternion.identity);

            cloneS.transform.SetParent(can.transform);
            cloneL.transform.SetParent(can.transform);
            cloneQ.transform.SetParent(can.transform);
            cloneP.transform.SetParent(can.transform);


            nt = cloneL.GetComponent<note>();

            if (e == 3)
            {
                e = -1;
            }
            
        }


    }
}
