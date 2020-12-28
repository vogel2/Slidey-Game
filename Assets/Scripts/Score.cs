using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;

    // Update is called once per frame
    public void Update()
    {
       ScoreText.text = (Player.position.z / 200).ToString("0");
    }
}

