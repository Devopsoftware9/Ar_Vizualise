using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
public class Rotation : MonoBehaviour
{
     
   public ARFaceManager faceManager;
    public Text t;
    void Start()
    {
        StartCoroutine("start");
    }

    
    IEnumerator start()
    {
        while (true)
        {
            if ((faceManager.trackables.count > 0))
            {
                foreach (ARFace face in faceManager.trackables)
                {
                    Quaternion rot = face.transform.rotation;
                    Vector3 SampRot = rot.eulerAngles;
                    t.text = SampRot.ToString();
                    yield return new WaitForSeconds(2);
                }
            }
        }
        
          
    }
}