using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseButton : MonoBehaviour
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
        Buttontoshow.onClick.AddListener(Change);

    }

    // change the methode which contains the ations that we want to do with button click
    void Change()
    {
        o1.SetActive(false);
        o2.SetActive(false);
        o3.SetActive(true);

        WallofLivingRoom.SetActive(false);
        sofa.SetActive(false);
        faizaFloor.SetActive(false);
        KitchenFloor.SetActive(false);
        obj2.SetActive(false);
        Insidekitchenfloor.SetActive(false);
        ColorSofa1.SetActive(false);
        Button.gameObject.SetActive(true);
        Buttontoshow.gameObject.SetActive(false); ;
    }
}
