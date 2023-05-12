using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeButton : MonoBehaviour
{
    public Sprite image;
    public void Changebutton(Button button)
    {
        button.GetComponent<Image>().sprite = image;
       
    }
}
