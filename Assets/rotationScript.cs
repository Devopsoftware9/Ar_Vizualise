using UnityEngine;
using UnityEngine.UI;

public class rotationScript : MonoBehaviour
{
    public GameObject rightFrame;
    public GameObject LeftFrame;
    public Text t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rightFrame.SetActive(false);
        LeftFrame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         Quaternion q=transform.rotation;
         Vector3 v=q.eulerAngles;
         t.text=v.ToString();
         if(v.y<170)
         {
             rightFrame.SetActive(false);
             LeftFrame.SetActive(!false);
         }
         if(v.y>170)
         {
             rightFrame.SetActive(!false);
             LeftFrame.SetActive(!true);
         }
         if(v.y>170 && v.y<180)
         {
            rightFrame.SetActive(!true);
             LeftFrame.SetActive(!true);
         }
    }
}
