using UnityEngine;
using System.Collections;
public class displayText : MonoBehaviour
{
    //Declaring variables
    bool crossedBoundary;
    void OnTriggerEnter(Collider other)
    {
        //Telling game to actiavte boolean
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collision!");
          
            crossedBoundary = true;
            OnGUI();
        }
    }
    void OnGUI()
    {
        //If the boolean is active, display the text
        if (crossedBoundary == true)
        {
            GUI.Label(new Rect(200, 100, 0, 0), "Press E to port");
        }
    }
}