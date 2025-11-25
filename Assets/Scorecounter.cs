using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorecounter : MonoBehaviour
{
    TextMeshProUGUI textmesh;

    public int score;
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }

    
    void Update()
    {
        textmesh.text = score.ToString();
    }
}
