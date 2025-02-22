using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
public class sliding : MonoBehaviour
{
    public Button b;
    int num = 0;
    public RectTransform img1;
    public RectTransform img2;
    public RectTransform img3;
    public RectTransform img4;
    public RectTransform img5;
    float transtion = 0;
    bool anim = !false;
    void Start()
    {
        b.onClick.AddListener(click);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (num == 1)
        {
            StartCoroutine("increase");
            img1.anchoredPosition=Vector2.Lerp(img1.anchoredPosition,new Vector2(-700,0),transtion);
            img2.anchoredPosition = Vector2.Lerp(img2.anchoredPosition, new Vector2(-700, 0), transtion);
            img3.anchoredPosition = Vector2.Lerp(img3.anchoredPosition, new Vector2(-700, 0), transtion);
            img4.anchoredPosition = Vector2.Lerp(img4.anchoredPosition, new Vector2(-700, 0), transtion);
            img5.anchoredPosition = Vector2.Lerp(img5.anchoredPosition, new Vector2(-700, 0), transtion);

        }
    }
    void click()
    {

        Debug.Log("clicked");
        num = 1;
    }
    IEnumerator increase()
    {
        
        
            while(anim)
            {
                  
                    yield return new WaitForSeconds(0.05f);
                    transtion += 0.01f;
                
               
            }
            
         
        
    }
}
