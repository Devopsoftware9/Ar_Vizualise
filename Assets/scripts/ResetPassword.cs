using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ResetPassword : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     public Button Reset;

    void Start()
    {
    Reset.onClick.AddListener(Forgot);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void Forgot()
    {
        SceneManager.LoadScene(7);
    }
}
