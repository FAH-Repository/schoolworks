using UnityEngine;
using System.Collections;

using UnityEngine.UI;
public class playerhealth : MonoBehaviour {
    public float maxhealth = 100f;
    public float curhealth = 100f;
    public float maxenergy = 50f;
    public float curenergy = 50f;
    private GUIStyle currentStyle = null;
    private GUIStyle currentStyles = null;
    public float healthBarLength;
    public float energyBarLength;
    public GameObject shootE;
   public bool okToShoot;
    public Image I;
 public float flashSpeed = 3f;
    public Color flashColour = new Color(30f, 0f, 0f, 0.7f);
    public bool damaged;
public float regenTimer;
    // public int hieght;
    // public int width;
    // Use this for initialization
    void Start () {
        healthBarLength = Screen.width / 2;
        energyBarLength = Screen.width / 2;
    }
	
	// Update is called once per frame
	void Update () {
        AddjustCurHealth(0);
        curenergy += 10 * Time.deltaTime;
       regenTimer -= 3 * Time.deltaTime;
      
        if (damaged == true)
        {
            I.color = flashColour;
            regenTimer = 10;
        }
        else 
{
            I.color = Color.Lerp(I.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
        if (regenTimer < 0) 
{
            regenTimer = 0;

 }
        if (curhealth < maxhealth && regenTimer == 0)
        {
            curhealth += 10 * Time.deltaTime;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            curhealth -= 5;
        }

    }
    void OnGUI(){
       
        InitStyles();
        InitStyle();
        GUI.depth = -3;
        GUI.Box(new Rect(10, 10, healthBarLength, 20),"", currentStyle);
        GUI.Box(new Rect(10, 30, energyBarLength, 20), "", currentStyles);
    }// curhealth + "/" + maxhealth
    private void InitStyle() {
        if (curhealth > 30) {
            if (currentStyle == null) {
                currentStyle = new GUIStyle(GUI.skin.box);
                currentStyle.normal.background = MakeTex(2, 2, new Color(1f, 0f, 0f, 1f));
            }                                                    //0, 1, 0, .5
        } 
   
    }
    private void InitStyles()
    {

        if (currentStyles == null)
        {
            currentStyles = new GUIStyle(GUI.skin.box);
            currentStyles.normal.background = MakeTex(2, 2, new Color(0f, 0f, 1f, 1f));
        }                                                    //0, 1, 0, .5

    }
    private Texture2D MakeTex(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; ++i)
        {
            pix[i] = col;
        }
        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }



    public void AddjustCurHealth(int adj) {
        curhealth += adj;
     
        energyBarLength = (Screen.width / 3) * (curenergy / (float)maxenergy);
        if (curenergy > maxenergy)
        {
            curenergy = 50;
        }
        if (curenergy < 0)
        {
            curenergy = 0;
        }
        if (curenergy < 10)
        {
            okToShoot = false;
        }
        else if(curenergy > 10)
        {
            okToShoot = true;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && okToShoot == true)
        {
            curenergy -= 10;

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

        healthBarLength = (Screen.width / 3) * (curhealth / (float)maxhealth);
    }
}
