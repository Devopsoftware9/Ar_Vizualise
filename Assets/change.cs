using UnityEngine;

public class change : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject edith_glass;
    public GameObject d145_04_black;
    void Start()
    {
        edith_glass.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void edith()
    {
        Instantiate(edith_glass,new Vector3(9.99999975e-05f,9.99999975e-05f,-0.0577999987f),Quaternion.Euler(new Vector3(3.13191652f,179.343079f,0.648679733f)));
        Destroy(d145_04_black);


    }
}
