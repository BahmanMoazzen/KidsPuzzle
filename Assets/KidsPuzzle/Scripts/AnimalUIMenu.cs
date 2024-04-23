using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnimalUIMenu : MonoBehaviour
{
    [SerializeField] Image _myPic;
    int _MyId = 0;

    public void _Update(Sprite iImage,int iID)
    {
        _MyId = iID;
        _myPic.sprite = iImage;
    }
    public void _Click()
    {
        GameManager._Instance._UpdateAnimal(_MyId);
    }
}
