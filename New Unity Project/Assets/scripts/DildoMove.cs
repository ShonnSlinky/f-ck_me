using UnityEngine;
using System.Collections;

public class DildoMove : MonoBehaviour {

    //после того, как взяли дилдо...
    [SerializeField]
    public GameObject text_finddildo;

    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    float distanse = 1;
    void OnMouseDrag()
    {
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanse);
        Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = objPos;
        
        //...удаляем сообщение о поиске дилдо
        Destroy(text_finddildo);
    }

}
