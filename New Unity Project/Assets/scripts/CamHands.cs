using UnityEngine;
using System.Collections;

public class CamHands : MonoBehaviour {

    [SerializeField]
    public Texture2D handone;

    [SerializeField]
    public Texture2D handtwo;

    [SerializeField]
    public Texture2D handfree;

    [SerializeField]
    public Camera _camera;

    // Use this for initialization
    void Start () {
        //заблокировать курсор в центре экрана
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnGUI()
    {
        float posX = _camera.pixelWidth / 2 - 41 / 4;
        float posY = _camera.pixelHeight / 2 - 64 / 2;
        GUI.DrawTexture(new Rect(posX, posY, 41, 64), handone);
    }

}
