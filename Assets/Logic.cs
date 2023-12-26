using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    // Start is called before the first frame update

    int Player_score = 0;
    public Text text;

    public void addScore()
    {
        Player_score++;
        text.text=Player_score.ToString();
    }
}
