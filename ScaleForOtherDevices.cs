using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleForOtherDevices : MonoBehaviour
{
    float ScreenRatio = 1f;

    public GameObject Logo;
    public GameObject ScoreBoard;


    void Start()
    {
        ScaleCalculate(); 
    }

    void Update()
    {  
        //flipPhone tarz� cihazlarda anl�k katlama a�ma i�in
        //sabit ekranl� cihazlar i�in bu k�s�m �art de�il!

        //For foldable screen devices
        //Not need for normal screen devices
        ScaleCalculate();
        //




    }
    public void ScaleCalculate()
    {
        ScreenRatio = (float)Screen.height / (float)Screen.width;  //ekran�n oran� hesaplan�r  //calculate screen ratio  

        if (ScreenRatio < 1.6f && ScreenRatio < 1.8f) //Tablets, Ipads (4:3)
        {
            Logo.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            ScoreBoard.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 1600);
        }
        else if (ScreenRatio >= 1.6f && ScreenRatio < 1.8f)//Normal Telefon 16:9 gibiler   //16:9 Devices
        {
            Logo.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            ScoreBoard.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 2000);
        }
        else //uzat�lm�� ekranl� telefon 17:9 ve �zeri  //extended screen devices  (17:9)
        {
            Logo.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            ScoreBoard.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 2400);
        }
    }
}