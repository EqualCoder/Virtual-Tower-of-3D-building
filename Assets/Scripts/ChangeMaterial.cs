using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMaterial : MonoBehaviour
{
    public GameObject Wall;

    public Texture[] Textures;

    private Renderer WallRender;

    private int Index;

    // Update is called once per frame
    void Start()
    {
        WallRender = Wall.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeTexture);
    }
    void ChangeTexture() 
    {
        Index = Random.Range(0, Textures.Length);
        WallRender.material.mainTexture = Textures[Index];

    }
}
