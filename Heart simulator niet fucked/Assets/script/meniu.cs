using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meniu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void menu(int changescene) {
        SceneManager.LoadScene(changescene);
}

   public void exitt()
    {
        Application.Quit();
    }
}
