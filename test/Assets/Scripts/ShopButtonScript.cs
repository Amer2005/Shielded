using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopButtonScript : MonoBehaviour
{

    public Sprite buttonSkin;

    int number = 0;

    // Use this for initialization
    void Start()
    {
        SkinNow.skins.Add(buttonSkin);
        number = SkinNow.skins.Count - 1;
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void buttonClicked()
    {
        Debug.Log(number + " " + SkinNow.Skin);

        SkinNow.Skin = number;
    }
}
