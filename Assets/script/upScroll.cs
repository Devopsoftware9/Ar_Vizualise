using UnityEngine;

public class upScroll : MonoBehaviour
{
    float pos;
    float moved;
    float final;
    float res;
    int counter = 0;
    public RectTransform r;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.touchCount > 0 && counter==0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began)
            {
                pos = t.position.y;
            }
            if(t.phase == TouchPhase.Ended)
            {
                final= t.position.y;
                
                
            }
            if (final - pos > 1000)
            {
                Debug.Log("up");
                Vector3 vect = r.position;
                vect.y += 80;
                r.position = vect;

            }

        }
        else
        {
            
        }
        
    }
}
