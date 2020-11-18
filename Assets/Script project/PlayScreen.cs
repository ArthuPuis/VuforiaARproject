using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScreen : MonoBehaviour
{
    public GameObject rules = null;
    public GameObject gameplay = null;

    // Start is called before the first frame update
    void Start()
    {
        rules.SetActive(true);
        gameplay.SetActive(false);
    }

    public void printRules()
    {
        rules.SetActive(true);
        gameplay.SetActive(false);
    }

    public void printGameplay()
    {
        gameplay.SetActive(true);
        rules.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
