using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockItem : MonoBehaviour
{
    public GameObject Item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            int count = Random.Range(1, 10);
            if (count == 1)
            {
                Instantiate(Item, this.gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
