using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    GameObject player;

    // Use this for initialization
    void Start()
    {
        // Playerの部分はカメラが追いかけたいオブジェクトの名前をいれる
        this.player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y + 2, transform.position.z);

		//if (transform.position.x < -9)
		//{
		//	transform.position = new Vector3(-9, transform.position.y, transform.position.z);
		//}

		//if (playerPos.x < -9)
		//{
		//	playerPos.x = -9;
		//}
	}
}
