using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    private Vector3 pos;
    private Rigidbody rb;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pos = new Vector3(Random.Range(10.0f,-10.0f), Random.Range(10.0f, -10.0f), 0f);
            GameObject trueBullet = Instantiate(bullet, pos, Quaternion.identity);
            trueBullet.transform.localScale = new Vector3(1.0f, 1.0f, 5.0f);
        }
        
    }
}
