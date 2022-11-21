using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;
    GameObject score;


    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
        this.distance = GameObject.Find("Distance");
        this.score = GameObject.Find("Score");

    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<Text>().text = "距離目標還有: " + length.ToString("F2") + "m";

        float ScoreNumber = 100 / length;
        this.score.GetComponent<Text>().text = "分數" + ScoreNumber.ToString("F2");
    }
}
