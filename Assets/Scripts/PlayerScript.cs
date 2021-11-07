using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Player _player;
    void Start()
    {
     _player = new Player();
     _player.name = "Austin";   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
