using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _Instance;

    private void Awake()
    {
        if (_Instance == null)
            _Instance = this;
    }
    [SerializeField] GameObject _AnimalUIParent;
    [SerializeField] GameObject _AnimalUIPrefab;
    [SerializeField] Transform[] _showPlaces;
    [SerializeField] AnimalController _animal;
    [SerializeField] AnimalInfo[] _allAnimals;
    [SerializeField] SpriteRenderer _backgroundSprit;
    [SerializeField] Sprite[] _allBgs;
    BAHMANBackButtonManager _backButtonManager;
    int _currentAnimalIndex = 0;

    public void _BackButtonClick()
    {
        _backButtonManager._ShowMenu();
    }
    void Start()
    {
        _backButtonManager = FindFirstObjectByType<BAHMANBackButtonManager>();
        _UpdateAnimal(_currentAnimalIndex);
        StartCoroutine(_UpdateUI());
    }

    int _nextAnimalIndex()
    {
        _currentAnimalIndex++;
        if (_currentAnimalIndex >= _allAnimals.Length)
        {
            _currentAnimalIndex = 0;
        }
        return _currentAnimalIndex;
    }
    int _preAnimalIndex()
    {
        _currentAnimalIndex--;
        if (_currentAnimalIndex < 0)
        {
            _currentAnimalIndex = _allAnimals.Length - 1;
        }
        return _currentAnimalIndex;
    }
    public void _LoadNextAnimal()
    {
        _UpdateAnimal(_nextAnimalIndex());
    }
    public void _LoadPreAnimal()
    {
        _UpdateAnimal(_preAnimalIndex());
    }
    IEnumerator _UpdateUI()
    {
        for (int i = 0; i < _allAnimals.Length; i++)
        {
            var go = Instantiate(_AnimalUIPrefab, _AnimalUIParent.transform);
            go.GetComponent<AnimalUIMenu>()._Update(_allAnimals[i]._Image, i);
            yield return 0;
        }
    }
    public void _ChangeShowPlace(int iPlace)
    {
        _animal.gameObject.transform.position = _showPlaces[iPlace].position;
    }
    public void _UpdateAnimal(int iAnimalId)
    {
        _currentAnimalIndex = iAnimalId;
        _animal._LoadAnimal(_allAnimals[iAnimalId]);
        _backgroundSprit.sprite = _allBgs[Random.Range(0, _allBgs.Length)];
    }



}
