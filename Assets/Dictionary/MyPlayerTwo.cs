using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerTwo : MonoBehaviour
{
    public Dictionary<string,int> footballPlayers = new Dictionary<string,int>();
    // Start is called before the first frame update
    void Start()
    {
        footballPlayers.Add("Shuvam",1);
        footballPlayers.Add("Ateet",2);
        footballPlayers.Add("Sai",3);
        footballPlayers.Add("Aravind",4);
        footballPlayers.Add("Rishov",5);
        footballPlayers.Add("GOpal",6);
        
        var footballPlayerAge = footballPlayers["Shuvam"];
        foreach (KeyValuePair<string,int> item in footballPlayers)
        {
            Debug.Log("Player Age: " +item.Value);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
