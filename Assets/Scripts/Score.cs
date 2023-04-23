using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] TextMeshProUGUI text;
    private int score;
    void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        score = 0;
        text.text=""+score.ToString();
    }
    
    public void ScoreUpdate()
    {
         score +=10;
         text.text =""+score.ToString();
         
    }

}
