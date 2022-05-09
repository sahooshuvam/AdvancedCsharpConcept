using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayers : MonoBehaviour
{
    public Dictionary<int,Player> playerDictionary = new Dictionary<int,Player>(); 
    // Start is called before the first frame update
    void Start()
    {
        Player playerOne = new Player(10);
        playerOne.name = "Shuvam";
        Player playerTwo = new Player(20);
        playerTwo.name = "Ateet";
        Player playerThree = new Player(30);
        playerThree.name = "Sai";

        playerDictionary.Add(playerOne.id,playerOne);
        playerDictionary.Add(playerTwo.id,playerTwo);   
        playerDictionary.Add(playerThree.id,playerThree);

        var playerTwoId =  playerDictionary[playerTwo.id];
        Debug.Log("Player Two Name: " +playerTwoId.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
