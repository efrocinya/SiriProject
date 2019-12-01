using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverviewObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        transform.SetParent(transform.parent.parent);
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Overview");
        
    }
    private void OnLevelWasLoaded(int level)
    {
        transform.SetParent(GameObject.Find("Respawn").transform);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(0,0,0);
        transform.localScale = Vector3.one * 4;
    }
}
