using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class forgotPassword  : MonoBehaviour
{
      
     public Button ForgotPassword;
    void Start()
    {
        
        ForgotPassword.onClick.AddListener(Forgot);
    }

        void Loging()
    {
        Debug.Log("hi");
        SceneManager.LoadScene(3);
    }
    void reg()
    {
        SceneManager.LoadScene(5);
    }
    void Cont()
    {
        SceneManager.LoadScene(8);
    }
    void Forgot()
    {
        SceneManager.LoadScene(6);
    }
}


