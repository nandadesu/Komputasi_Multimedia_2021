﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

    public GameObject CoinText;
    public static int theScore;

    void Update()
    {
        CoinText.GetComponent<Text>().text = "SCORE : " + theScore;
    }
}
