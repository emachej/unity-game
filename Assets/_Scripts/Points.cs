using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{

    public Text pointDisplay;

    int points;

    // Start is called before the first frame update
    void Start()
    {
        pointDisplay.text = "Points: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        points = varHandler.r1points + varHandler.r2points;
        if(scene.name == "Win") {
            pointDisplay.text = "Total Points: " + points.ToString();
        } else {
            pointDisplay.text = "Points: " + points.ToString();
        }
    }
}
