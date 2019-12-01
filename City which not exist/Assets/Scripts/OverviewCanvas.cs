using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OverviewCanvas : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [Header("Set in Inspector")]
    public GameObject _respawn;

    private Vector2 oldPoint1, newPoint1;
    private Vector2 _touch1, _touch2,_oldtouch1,_oldtouch2;
    private float _angle, _curangle, _scale=1,_olddist,_dist,k=1;
    
    void Start()
    {
        _angle = 0;
        _curangle = 0;
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        oldPoint1 = eventData.position;
        if (Input.touchCount >= 2)
        {
            _oldtouch1 = Input.GetTouch(0).position;
            _oldtouch2 = Input.GetTouch(1).position;
            _olddist = Vector2.Distance(_oldtouch1, _oldtouch2);
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Input.touchCount == 1)
        {
            _curangle = oldPoint1.x - eventData.position.x;
        }

        if (Input.touchCount >= 2)
        {
            _dist = Vector2.Distance(Input.GetTouch(0).position, Input.GetTouch(1).position);
            k = _dist / _olddist;
        }
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Input.touchCount == 1)
        {
            _angle += _curangle;
            _curangle = 0;
        }
        if (Input.touchCount >= 2)
        {
            _scale *= k;
            k = 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _respawn.transform.rotation = Quaternion.Euler(0, (_angle+_curangle)*0.3f, 0);
        _respawn.transform.localScale = new Vector3(_scale * k, _scale * k, _scale * k);
    }
    public void onCardsSceneFromOverView()
    {
        if (ManagerMarks._useManagerMarks == true)
        {
            ManagerMarks._useManagerMarks = false;
            SceneManager.LoadScene("CardsScene");
            
        }
        else
        {
            SceneManager.LoadScene("ARCamera");
        }
    }
}
