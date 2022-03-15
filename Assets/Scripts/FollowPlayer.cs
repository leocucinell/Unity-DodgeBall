using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4, player.transform.position.z + -8);
    }

    private void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 4, player.transform.position.z + -8);
    }
}
