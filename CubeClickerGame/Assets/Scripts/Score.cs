using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]    private Text    scoreText;
                        public  int     scoreCount;

    private void Update()
    {
        scoreText.text = "Score: " + scoreCount.ToString();
    }
}
