using UnityEngine;
using System.Collections;

public class WeaoponCon : MonoBehaviour {
    public GameObject bulletPrefab;
    public int mouseButtonId = 0;
    public KeyCode fireKey = KeyCode.Return;
    public GameObject shooter;
    public GameObject self;
    public AudioSource whistle;
    public AudioSource whoosh;
    //bool canShoot = true;
    // float shotDelay = .255f;


    // Use this for initialization
    void Start() {
        if (bulletPrefab == null) {
            Debug.LogError("weapon controller has no bullet to clone");


        }
    }

    // Update is called once per frame
    void Update() {
        if (ShotWasAttempted() == true /* && canShoot == true */) {

            Shoot();

        }
    }
    void Shoot() {
        playerhealth eh = (playerhealth)self.GetComponent("playerhealth");
        if (eh.okToShoot == true) {
            Instantiate(bulletPrefab, shooter.transform.position, this.transform.rotation);
        }
        // canShoot = false;
        // if(shotDelay > 0f){
        //()s
        //         Invoke("EnableShooting", shotDelay);
        //     }


    }
    bool ShotWasAttempted() {

        return Input.GetMouseButtonDown(mouseButtonId) || Input.GetKeyDown(fireKey);

        if (Input.GetMouseButtonDown(mouseButtonId)) {
            //Emit some particle
            whistle.Play();
            whoosh.Play();

        }


    }
}
 //   void EnableShooting()
 //   {
 //  canShoot = true; 
 //   }
  //  void DisableShooting()
// {
//   canShoot = false;
    
    
  //  }
   

/* should be attached to gun, seperate empty object from parent player, positioned outside player collider */

