using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isDead = false;
    public float speed = 5.0f;
    public float accelSpeed = 0.5f;
    Rigidbody rb;
    bool  isStart = false;
    public ScoreMane scoreMane;
    public GameObject explosionPrefab;
    public AudioClip touchBarSE;
    public AudioClip touchOtherSE;

    AudioSource audiosouse;
    void Start()
    {
        audiosouse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStart == false && Input.GetMouseButtonDown(0))
        {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(1, -1, 0) * speed, ForceMode.VelocityChange);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            scoreMane.AddScore();
            Destroy(collision.gameObject);
            GameObject explosion = Instantiate(explosionPrefab, collision.transform.position, Quaternion.identity);
            explosion.transform.localScale = new Vector3(0.6f,0.6f,0.6f);
        }
        if (collision.gameObject.name == "Under")
        {
            isDead = true;
        }
        if (collision.gameObject.name == "Bar")
        {
            scoreMane.ResetCombo();
            speed += accelSpeed;
            Vector3 vec = transform.position - collision.transform.position;
            rb.velocity = Vector3.zero;
            rb.AddForce(vec.normalized * speed, ForceMode.VelocityChange);
            audiosouse.PlayOneShot(touchBarSE);
        }
        else
        {
            audiosouse.PlayOneShot(touchOtherSE);
        }
    }
}
