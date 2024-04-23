using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalController : MonoBehaviour
{
    AnimalInfo _info;
    [SerializeField] SpriteRenderer _Image;
    [SerializeField] Text _name_FA, _name_EN;
    [SerializeField] AudioSource _audioSource;
    [SerializeField] GameObject _noSound;

    public void _LoadAnimal(AnimalInfo iAnimal)
    {
        StopAllCoroutines();
        StartCoroutine(_loadAnimalRoutine(iAnimal));
    }
    IEnumerator _loadAnimalRoutine(AnimalInfo iAnimal)
    {
        _info = iAnimal;
        _name_FA.text = _info._Name_FA;
        _name_EN.text = _info._Name_EN;
        _Image.sprite = _info._Image;
        if (_info._Noises.Length > 0)
        {
            _noSound.SetActive(false);
        }
        else
        {
            _noSound.SetActive(true);
        }
        yield return null;
    }
    public void _Replace(Transform iNewPlace)
    {
        gameObject.transform.position = iNewPlace.position;
    }
    public void _PlayAnimalSound()
    {
        if (_info._Noises.Length > 0)
        {
            
            _audioSource.clip = _info._Noises[Random.Range(0, _info._Noises.Length)];
            _audioSource.Play();
        }

        //Debug.Log("Animal Sound");
    }
    public void _PlayFAName()
    {
        _audioSource.clip = _info._Pronaunse_FA;
        _audioSource.Play();
        //Debug.Log("Animal FA Name");
    }
    public void _PlayENName()
    {
        if (_info._Pronaunse_EN != null)
        {
            _audioSource.clip = _info._Pronaunse_EN;
            _audioSource.Play();
        }
        //Debug.Log("Animal EN Name");
    }
    private void OnMouseDown()
    {
        _PlayAnimalSound();
    }
}
