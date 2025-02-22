using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Login  : MonoBehaviour
{
     public Button Logins;
     public Button Continue;
     public Button Register;
    void Start()
    {
        Logins.onClick.AddListener(Loging);
        Continue.onClick.AddListener(Cont);
        Register.onClick.AddListener(reg);
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
}


