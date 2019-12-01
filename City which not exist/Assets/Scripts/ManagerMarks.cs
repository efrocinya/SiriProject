using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMarks : MonoBehaviour
{
    public static int _curMark;
    public static bool _useManagerMarks=false;

    [Header("Set in Inspector")]
    public GameObject[] _marksObjects;
    public GameObject _respawn;
    public GameObject _discription;

    private GameObject _curMarkObject;
    // Start is called before the first frame update
    void Start()
    {
       if (_useManagerMarks == true)
        {
            _curMarkObject = Instantiate<GameObject>(_marksObjects[_curMark]);
            _curMarkObject.transform.SetParent(_respawn.transform);
            _curMarkObject.transform.localPosition = Vector3.zero;
            _curMarkObject.transform.localScale = Vector3.one * 4.0f;
            _curMarkObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
