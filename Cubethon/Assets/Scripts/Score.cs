using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Transform playerTransform;
    // Update is called once per frame
    void Update()
    {
        // "0" is added in ToString() to convert float value of 
        // playerTransform.position.z to int
        scoreText.text = playerTransform.position.z.ToString("0");
    }
}
