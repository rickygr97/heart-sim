using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoteDestroyer : MonoBehaviour {

    public GameObject emty;
    public GameObject thirtfull;
    public GameObject secondfull;
    public GameObject Full;
    public int health = 0;
    GameObject notes;
    public GameObject gameOver;
    private bool gameOverBool = false;


    void Start()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "note")
        {
            notes = collision.gameObject;
            health++;
            HealthDestroy();
            Destroy(notes);
        }

        
    }

    void HealthDestroy()
    {
        switch (health)
        {
            case 2:
                Destroy(Full);
                break;
            case 4:
                Destroy(secondfull);
                break;
            case 6:
                Destroy(thirtfull);
                gameOver.SetActive(true);                
                gameOverBool = true;
                StartCoroutine(GoToMenu());
                note.speed = 100;
                break;
        }
    }


    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(2);
            
            SceneManager.LoadScene(0);
         
        



    }
}
