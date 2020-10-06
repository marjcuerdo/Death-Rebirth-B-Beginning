﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void Update() {

    	scoreText.text = "SCORE: " + score.ToString();
    }

    public void AddPoints(int points) {
    	score += points;
    }
}
