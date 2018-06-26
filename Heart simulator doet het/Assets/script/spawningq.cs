using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningq : MonoBehaviour {

    public Transform tf;

    public Transform prefab;

    public Canvas can;

    public int spwnspped = 6;

    void Start()
    {
        StartCoroutine(spawning());
        //   prefab.transform.SetParent



    }

    // Update is called once per frame
    void Update()
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
            yield return new WaitForSeconds(spwnspped);

            var clone = Instantiate(prefab, tf.transform.position, Quaternion.identity);

            clone.transform.SetParent(can.transform);

            if (e == 3)
            {
                e = -1;
            }

        }


    }
}
