using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerhealth : MonoBehaviour {
    public float maxhealth = 100f;
    public float curhealth = 100f;
    public Texture aTexture;
    private GUIStyle currentStyle = null;
    public float healthBarLength;
    public int hieght;
    public int width;
    public int potionNum;
    public GameObject potion;
    public GameObject player;
    public float potUseDis;
    private Transform myTransform;
    public Transform teleportTarget;
    public Slider healthSlider;

   
    public Text num = null;
    // Use this for initialization
    void Start () {
      
        healthBarLength = Screen.width / 2;
        
	}

    // Update is called once per frame
    void Update()
    {
      
        AddjustCurHealth(0);
       
    }
    //void OnGUI(){
       
    ////    GUI.DrawTexture(new Rect(10, 10, 210, 20), aTexture, ScaleMode.ScaleToFit, true, 10.0F);
    //    InitStyles();
    //  //  GUI.depth = 0;
    //    GUI.Box(new Rect(10, 10, healthBarLength, 20),curhealth + "/" + maxhealth, currentStyle);     
    //}
    //private void InitStyles() {
    //    if (curhealth > 30) {
    //        if (currentStyle == null) {
    //            currentStyle = new GUIStyle(GUI.skin.box);
    //            currentStyle.normal.background = MakeTex(2, 2, new Color(0f, 1f, 0f, 0.5f));
    //        }                                                    //0, 1, 0, .5
    //    } 
    //    else if (curhealth < 30)
    //    {
    //        if (currentStyle == null) 
    //            {
    //            currentStyle = new GUIStyle(GUI.skin.box);
    //            currentStyle.normal.background = MakeTex(2, 2, new Color(1f, 0f, 0f, 1f));
    //            }
    //    }
    //}
    //private Texture2D MakeTex(int width, int height, Color col) {
    //    Color[] pix = new Color[width * height];
    //    for (int i = 0; i < pix.Length; ++i) {
    //        pix[i] = col;
    //    }
    //    Texture2D result = new Texture2D(width, height);
    //    result.SetPixels(pix);
    //    result.Apply();
    //    return result;
    //}


   
    public void AddjustCurHealth(int adj) {
        curhealth += adj;
     
        float distance = Vector3.Distance(potion.transform.position, transform.position);
        if (distance <= potUseDis && Input.GetKeyDown(KeyCode.E))
        {
           
            potionNum += 1;
            // Destroy(potion);
            potion.transform.position += new Vector3(300, 300, 300);
        }
        if (potionNum > 0 && Input.GetKeyDown(KeyCode.L))
        {
                potionNum -= 1;
                curhealth += maxhealth;
        }

        if (curhealth < 1) {
            curhealth = 0;
        }
        if (curhealth > maxhealth) {
            curhealth = maxhealth;
        }
         
            if (maxhealth < 1)
        {
            maxhealth = 1;

        }
       
        healthSlider.value = curhealth;
       // healthBarLength = (Screen.width / 3) * (curhealth / (float)maxhealth);
    }
      
}
