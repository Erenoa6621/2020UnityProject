using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    float posY;
    private bool target;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        posY = transform.position.y;
        target = false;
        count = 200;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Input.mousePosition;
        Vector3 targetPos = Camera.main.ScreenToWorldPoint(new Vector3(pos.x, pos.y, 10));
       
        if (target == false)
        {
            this.gameObject.transform.localScale = new Vector3(1.5f, 0.25f, 0.25f);
            targetPos.x = Mathf.Clamp(targetPos.x, -1.3f, 2.0f);
            targetPos.y = posY;
            transform.position = targetPos;
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(2.5f, 0.25f, 0.25f);
            targetPos.x = Mathf.Clamp(targetPos.x, -0.8f, 1.5f);
            targetPos.y = posY;
            transform.position = targetPos;
            count++;
        }
        if (count > 800)
        {
            target = false;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            count = 0;
            target = true;
            Destroy(other.gameObject);
        }
    }
}
