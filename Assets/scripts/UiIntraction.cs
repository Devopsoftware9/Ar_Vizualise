using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class UiIntraction : MonoBehaviour
{
     public Button GettingStarted;
    void Start()
    {
        GettingStarted.onClick.AddListener(gettingStarted);
    }

    // Update is called once per frame
    
    void gettingStarted()
    {
        
        SceneManager.LoadScene(2);
    }
}
