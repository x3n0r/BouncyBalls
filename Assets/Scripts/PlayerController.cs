using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{	
	public float speed;
	public GUIText countText;
	public GUIText winText;
	private int count;
	private int numberOfGameObjects;
    private Rigidbody rb;

    void Start()
	{
		count = 0;
		SetCountText();
		winText.text = "";
        rb = GetComponent<Rigidbody>();
    }
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
        
        rb.AddForce(movement * speed * Time.deltaTime);
    }
	
	void OnTriggerEnter(Collider other) 
	{
        
		if(other.gameObject.tag == "wall")
		{
            Debug.Log("collided" + other.name);

            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(-moveHorizontal, 1.0f, -moveVertical);

            rb.AddForce(movement * speed * Time.deltaTime,ForceMode.Impulse);
            //other.gameObject.SetActive(false);
			//count = count + 1;
			//SetCountText();
		}
	}
	
	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString();
		if(count >= numberOfGameObjects)
		{
			winText.text = "YOU WIN!";
		}
	}
}
