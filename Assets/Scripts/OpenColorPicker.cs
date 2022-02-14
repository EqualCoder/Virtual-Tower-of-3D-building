using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenColorPicker : MonoBehaviour
{
    //our button
    public Button Button;
    public Button Buttontoshow;

    //our GameObjects that we want to appear and desepear them
    public GameObject WallofLivingRoom;
    public GameObject sofa;
    public GameObject faizaFloor;
    public GameObject KitchenFloor;
    public GameObject obj2;
    public GameObject ColorSofa1;
    public GameObject Insidekitchenfloor;

    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    
    


    void Start()
    {
        Button.onClick.AddListener(Change);

    }

    // change the methode which contains the ations that we want to do with button click
    void Change()
    {
        o1.SetActive(true);
        o2.SetActive(true);
        o3.SetActive(true);
        
        WallofLivingRoom.SetActive(true);
        sofa.SetActive(true);
        faizaFloor.SetActive(true);
        KitchenFloor.SetActive(true);
        obj2.SetActive(true);
        Insidekitchenfloor.SetActive(true);
        ColorSofa1.SetActive(true);
        Button.gameObject.SetActive(false);
        Buttontoshow.gameObject.SetActive(true); ;
    }
}
