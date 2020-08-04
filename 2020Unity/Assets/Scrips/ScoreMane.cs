using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMane : MonoBehaviour
{
    // Start is called before the first frame update
    int score = 0;
    int baseScore = 10;
    int combo = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score : " + score;
    }

    public void AddScore()
    {
        combo++;
        score += combo * baseScore;
    }
    public void ResetCombo()
    {
        combo = 0;
    }

}
