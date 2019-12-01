using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARCameraManager : MonoBehaviour
{
    public GameObject _panel;

    public void ShowPanel()
    {
        if (_panel != null)
        {
            Animator animator = _panel.GetComponent<Animator>();
            if (animator != null)
            {
                bool isOpen = animator.GetBool("open");
                animator.SetBool("open", !isOpen);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onMenuFromARCamera()
    {
        SceneManager.LoadScene("MainScene");
    }
   

}
