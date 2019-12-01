using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onCardsFromMenu()
    {
        SceneManager.LoadScene("CardsScene");
    }
    public void onARCameraFromMenu()
    {
        SceneManager.LoadScene("ARCamera");
    }
    public void onShowSendFile()
    {
        SceneManager.LoadScene("SendFile");
    }
    public void onShowMenuFromShare()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void onShowSendFile2()
    {
        SceneManager.LoadScene("SendFile_1");
    }
    public void onShowSendFileFromSF2()
    {
        SceneManager.LoadScene("SendFile");
    }
}
