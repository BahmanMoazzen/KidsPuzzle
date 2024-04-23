using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Animal",menuName ="Kids Puzzle/New Animal",order =1)]
public class AnimalInfo : ScriptableObject
{
    public Sprite _Image;
    public string _Name_EN;
    public string _Name_FA;
    public AudioClip[] _Noises;
    public AudioClip _Pronaunse_EN;
    public AudioClip _Pronaunse_FA;
}
