using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndMenu : MonoBehaviour
{
    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
    }

    [SerializeField] TextMeshProUGUI text;
    public void Start() 
    {
        text.text ="Your Score: "+ Score.instance.score.ToString();
    }
}