using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    
    [SerializeField] private int correctNumber = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + correctNumber.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
