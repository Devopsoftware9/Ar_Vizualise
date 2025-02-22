using UnityEngine;
using System;
public class slidingRemake : MonoBehaviour
{
    public RectTransform rt;
    public RectTransform rt2;
    
    int speed = 500;
    float Distance;
    Ray r;
    RaycastHit hit;
    public LayerMask mask;
    float x;
    float y;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(rt.anchoredPosition, rt2.anchoredPosition);
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            x = t.position.x;
            y = t.position.y;
            
            if (t.phase == TouchPhase.Moved)
            {
               
                //canvas.renderMode = RenderMode.ScreenSpaceCamera;
                if (t.position.y > 140)
                {

                    rt.transform.Translate(new Vector3(0, speed, 0));
                }
                if (Distance < 2000)
                {
                    speed = 0;
                    Debug.Log("done");
                }
            }
            if (Physics.Raycast(r, out hit, 10, mask))
            {
                Debug.Log("fuck detected");
            }
        }
        Debug.Log(Distance);

    }
}
