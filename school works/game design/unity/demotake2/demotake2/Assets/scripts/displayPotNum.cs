using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class displayPotNum : MonoBehaviour {

    //UnityEngine.UI.Text potnum;
    public GameObject player;
    [SerializeField]
    public Text num = null;


    // Use this for initialization
    void Start () {
      // num = GetComponent<Text>();
        playerhealth potions = (playerhealth)player.GetComponent("potionNum");
        string p = potions.ToString();
        num.text = p;
    

    }

    // Update is called once per frame
    void Update () {
	
	}
}
