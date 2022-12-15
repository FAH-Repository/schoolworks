using UnityEngine;
using System.Collections;

public class powerUp : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    private GameController gameController;
   
 
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary" || other.tag == "Enemy")
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (other.tag == "Player")
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
         
            for (var i = 0; i < gameObjects.Length; i++)
            {
                Destroy(gameObjects[i]);
           
            }
        }


        gameController.AddScore(scoreValue);
        Destroy(gameObject);
    }
}
