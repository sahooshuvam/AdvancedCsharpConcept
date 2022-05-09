using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
   public List<Item> itemList = new List<Item>();
   public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();  
   
    // Start is called before the first frame update
    void Start()
    {
        Item knife = new Item();
        knife.name = "knife";
        knife.id = 0;
        Item bullet = new Item();
        bullet.name = "Bullet";
        bullet.id = 1;
        Item car = new Item();
        car.name = "Tata";
        car.id = 2;

        itemDictionary.Add(0, knife);
        itemDictionary.Add(1, bullet);
        itemDictionary.Add(2, car);
        
        itemList.Add(knife);
        itemList.Add(bullet);
        itemList.Add(car);

        //foreach (Item item in itemList)
        //{
        //    Debug.Log(item.name);
        //    Debug.Log(item.id);
        //}

        //foreach (KeyValuePair<int,Item> item in itemDictionary)
        //{
        //    Debug.Log("key :" + item.Key);
        //    Debug.Log("value :" + item.Value.name);
        //}
        
        //foreach (Item item in itemDictionary.Values)
        //{
        //    Debug.Log("Values :" + item.name);
        //}


        var myDisctionaryItem = itemDictionary[0];
        Debug.Log(myDisctionaryItem.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
