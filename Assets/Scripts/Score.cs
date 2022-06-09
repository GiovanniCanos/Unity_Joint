using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text textScore;
    public GameObject Points;
    public Transform Location;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        textScore.text = "Pontos: " + score;
        if (score >= 5)
        {
            Instantiate(Points, Location.position, Location.rotation);
        }
    }
}
