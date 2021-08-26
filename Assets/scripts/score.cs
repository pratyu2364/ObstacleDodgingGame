
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public Text myscore;

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Player.position.z);
        myscore.text = Player.position.z.ToString("0");

        
    }
}
