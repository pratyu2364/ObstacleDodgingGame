using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionofplayer : MonoBehaviour
{
    // Start is called before the first frame update
    public NewBehaviourScript movement;
    void OnCollisionEnter(Collision collisioninfo)
    {
       if(collisioninfo.collider.tag=="Obstacles")
       {
           movement.enabled = false;
           FindObjectOfType<GameManager>().EndGame();
       }
    }
}
