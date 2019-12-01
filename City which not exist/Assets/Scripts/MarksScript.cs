using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MarksScript : MonoBehaviour
{
    [Header("Set in Inspector")]
    public int _numberMark;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OverViewFromCard()
    {
        ManagerMarks._curMark = _numberMark;
        ManagerMarks._useManagerMarks = true;
        SceneManager.LoadScene("Overview");
    }
   
}
