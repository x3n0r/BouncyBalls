using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{	
	public float MaxSpeed;
	public float Speed;
	public Text txtRefSpeed;
	public Text txtRefWin;

	private Rigidbody rb;

    void Start()
	{
        rb = GetComponent <Rigidbody>();
    }
	
	void FixedUpdate ()
	{
		if (gameObject.transform.name == "Player1") {  
			float p1_moveHorizontal = Input.GetAxis("P1_Horizontal");
			float p1_moveVertical = Input.GetAxis("P1_Vertical");
			Vector3 p1_movement = new Vector3(p1_moveHorizontal, 0.0f, p1_moveVertical);
			rb.AddForce(p1_movement * MaxSpeed * Time.deltaTime);
		} else if (gameObject.transform.name == "Player2") {
			float p2_moveHorizontal = Input.GetAxis("P2_Horizontal");
			float p2_moveVertical = Input.GetAxis("P2_Vertical");		
			Vector3 p2_movement = new Vector3(p2_moveHorizontal, 0.0f, p2_moveVertical);
			rb.AddForce(p2_movement * MaxSpeed * Time.deltaTime);
		}
		Speed = rb.velocity.magnitude;
		txtRefSpeed.text = Speed.ToString();
    }
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.tag == "bossroom") {
			//winText.text = gameObject.transform.name + " WIN!";
			//Debug.Log (gameObject.transform.name + " WIN!");
			txtRefWin.text = gameObject.transform.name + " WIN!";
		}
	}
	//{

	//float moveHorizontal = Input.GetAxis("Horizontal");
	//float moveVertical = Input.GetAxis("Vertical");
	//Vector3 movement = new Vector3(-moveHorizontal, 1.0f, -moveVertical);

	//rb.AddForce(movement * speed * Time.deltaTime,ForceMode.Impulse);
	//other.gameObject.SetActive(false);
	//count = count + 1;
	//SetCountText();
	//}
	//void SetCountText ()
	//{
	//	countText.text = "Count: " + count.ToString();
	//	if(count >= numberOfGameObjects)
	//	{
	//		winText.text = "YOU WIN!";
	//	}
	//}
}
