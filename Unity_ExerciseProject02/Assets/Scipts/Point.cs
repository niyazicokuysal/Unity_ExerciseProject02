using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Point : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Player.point);
        scoreText.text = Player.point.ToString();
    }
}
