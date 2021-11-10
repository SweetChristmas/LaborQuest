using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JSONScript : MonoBehaviour
{
    private string path;
    private string jsonString;
    // Start is called before the first frame update
    void Start()
    {
        path = Application.dataPath + "/DataFiles/";
        Debug.Log(path);
    }
    public string readFile(string fileName) {
        if(path is null) {
            path = Application.dataPath + "/DataFiles/";
        }
        Debug.Log(path);
        jsonString = File.ReadAllText(path + fileName + ".json");
        return jsonString;
    }
}
