using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Spawn2 : MonoBehaviour
{

    public GameObject player;
    public float minX, maxX, minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        //Vector2 randomPosition = new Vector2 (Random.Range(minX,minY), Random.Range(maxX,maxY));
        Vector2 randomPosition = new Vector2(-7,-14);
        PhotonNetwork.Instantiate(player.name, randomPosition, Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
