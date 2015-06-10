using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private Vector3 pos;
    private Vector3 aimingDirection;
    private int shotCount;
    private LineRenderer line;

    public Text shotsFired;
    public float speed = .1f;
    void Start()
    {
        shotCount = 0;
        setCountText();
        line = GetComponent<LineRenderer>();
        
    }
    void setCountText()
    {
        shotsFired.text = "Shot Count: " + shotCount.ToString();
    }
    void Update()
    {
        // Help from http://answers.unity3d.com/questions/521688/use-the-mouse-to-aim.html
        pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y - transform.position.y);
        pos = Camera.main.ScreenToWorldPoint(pos);
        aimingDirection = pos - transform.position;
        //Help from http://docs.unity3d.com/ScriptReference/RaycastHit-normal.html
        if(Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                Vector3 incomingVec = hit.point - transform.position;
                Vector3 reflectVec = Vector3.Reflect(incomingVec, hit.normal);
                line.enabled = true;
                line.SetPosition(0, transform.position);
                line.SetPosition(1, hit.point);
                //Doesn't work. Why?
                //line.SetPosition(2, reflectVec.normalized);
            }

        }

    }

    void OnMouseUp()
    {
        line.enabled = false;
        GetComponent<Rigidbody>().velocity = new Vector3(aimingDirection.x, aimingDirection.y, aimingDirection.z) * speed * Time.deltaTime;
        shotCount++;
        setCountText();
    }
}