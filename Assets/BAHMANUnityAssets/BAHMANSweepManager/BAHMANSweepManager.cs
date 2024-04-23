using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BAHMANSweepManager : MonoBehaviour
{
    [SerializeField] bool _isDragging = false;
    [SerializeField] float _dragDuration = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Start Drag");
            if (!_isDragging)
            {
                _dragDuration = 0;
                _isDragging = true;
            }
        }
        else
        if (Input.GetMouseButton(0))
        {
            if (_isDragging)
            {
                Debug.Log("Dragging");
                _dragDuration += Time.deltaTime;
            }
        }
        else
        if (Input.GetMouseButtonUp(0)) { }
        {
            if (_isDragging)
            {
                _isDragging = false;

                Debug.Log("realeased: " + _dragDuration);
            }

        }
    }
}
