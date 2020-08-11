using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCon : MonoBehaviour
{
    public GameObject Clear;
    public GameObject Over;
    public GameObject ball;
    public GameObject ReTry;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");
        if (blocks.Length == 0)
        {
            Clear.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
            ReTry.SetActive(true);
        }

        if (ball.GetComponent<Ball>().isDead == true)
        {
            Over.SetActive(true);
            ball.GetComponent<Rigidbody>().isKinematic = true;
            ReTry.SetActive(true);
        }
    }
    public void ReTryCon()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
