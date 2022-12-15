using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour {
    public float maxhealth = 100f;
    public float curhealth = 100f;
    private GUIStyle currentStyles = null;
    public float healthBarLength;
    // Use this for initialization
    void Start () {
        healthBarLength = Screen.width / 2;
    }
	
	// Update is called once per frame
	void Update () {
        healthBarLength = (Screen.width / 3) * (curhealth / (float)maxhealth);
        if (curhealth == 0) 
            {
            Application.LoadLevel(1);
        }
    }
    void OnGUI()
    {

        InitStyles();
        GUI.Box(new Rect(10, 10, healthBarLength, 20), "", currentStyles);
    }
    private void InitStyles()
    {

        if (currentStyles == null)
        {
            currentStyles = new GUIStyle(GUI.skin.box);
            currentStyles.normal.background = MakeTex(2, 2, new Color(1f, 0f, 0f, 1f));
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
    void OnCollisionEnter(Collision col)
    {
     
        if (col.gameObject.tag == "spikes")
        {
            curhealth -= 100;
        }
 //       if (col.gameObject.tag == "enemy" || col.gameObject.tag == "enemyBullet")
 //{
 //           curhealth -= 20;
 //}
    }
    }
