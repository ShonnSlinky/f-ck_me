using UnityEngine;
using System.Collections;

public class CamSetCursor : MonoBehaviour {

    [SerializeField]
    public GameObject cam;
    [SerializeField]
    float Xmax;
    [SerializeField]
    float Ymax;
    [SerializeField]
    float Xmin;
    [SerializeField]
    float Ymin;

    public float xPos;
    public float yPos;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update () {
        xPos += Input.GetAxis("Mouse X");
        yPos += Input.GetAxis("Mouse Y");
        //Clamp выставляет границы для камеры на уровне
        cam.transform.position = new Vector3(Mathf.Clamp(xPos,Xmin,Xmax), Mathf.Clamp(yPos,Ymin,Ymax),-10);
    }
}
