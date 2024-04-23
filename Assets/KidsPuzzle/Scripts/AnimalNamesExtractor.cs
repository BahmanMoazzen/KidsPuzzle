using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalNamesExtractor : MonoBehaviour
{
    [SerializeField] AnimalInfo[] _allAnimals;
    void Start()
    {
        string nameFA=string.Empty, nameEN = string.Empty;
        foreach (var animal in _allAnimals)
        {
            nameEN +=$"{ animal._Name_EN} - ";
            nameFA += $"{animal._Name_FA} - ";
        }
        Debug.Log(nameFA);
        Debug.Log(nameEN);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
