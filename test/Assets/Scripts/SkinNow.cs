using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinNow : MonoBehaviour
{

    public static List<Sprite> skins = new List<Sprite>();

    public static int Skin = 0;

    SpriteRenderer playerSprite;

    // Use this for initialization
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        playerSprite.sprite = skins[Skin];
        Debug.Log(playerSprite.sprite);
    }
}
