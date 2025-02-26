using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;
public class timer : MonoBehaviour
{
    float seconds=2f;
    public RectTransform canvas;
    public RectTransform canvas2;
    public GameObject canvasDelete;
    public RectTransform login;
void Start()
{
    StartCoroutine("Timer");
}


void Update()
{
    
}
IEnumerator Timer()
{
    yield return new WaitForSeconds(seconds);
    //Debug.Log("hi");
    canvas2.position = canvas.position;
    Destroy(canvasDelete);
}
}
