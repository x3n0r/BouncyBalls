using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 

{
	public GameObject player;
	private Vector3 offset;
    private float x;
    private float y;
    private float z;
    // Use this for initialization
    void Awake () {
        //offset = transform.position;
        x = player.transform.position.x - transform.position.x;
        y = player.transform.position.y - transform.position.y;
        z = player.transform.position.z - transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x - x, player.transform.position.y -y, player.transform.position.z-z);
	}
}
