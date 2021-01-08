using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreskrip : MonoBehaviour
{
    private static int skor;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
      score = GetComponent<Text>();  
    }

    // Update is called once per frame
    void Update()
    {
        skor = descsampah.scoreValue;
        score.text = "Score:" + skor; 
        
    }
}
