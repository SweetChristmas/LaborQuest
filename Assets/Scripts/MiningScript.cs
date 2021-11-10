using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class MiningScript : MonoBehaviour
{
    private JSONScript jSONScript;
    private Items items;
    void Start()
    {
        jSONScript = new JSONScript();
        var newString = jSONScript.readFile("items");
        Debug.Log(newString);
        items = JsonConvert.DeserializeObject<Items>(newString);
        foreach(var item in items.items) {
            Debug.Log(item.name + ": " + item.value + ". Is stackable: " + item.isStackable);
        }
    }

}
