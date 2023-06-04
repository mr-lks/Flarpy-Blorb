using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public int Score = 0;

    public Text ScoreText;
    void Start()
    {

        UpdateScore(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(bool init = false)
    {

        if (init == true)
        {

            ScoreText.text = Score.ToString();

        }
        else
        {

            Score++;
            ScoreText.text = Score.ToString();
        }


    }

}
