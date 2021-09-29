using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    float jumpForce = 400.0f;
    float moveForce = 10.0f;
    float maxMoveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid.AddForce(transform.up * this.jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(this.rigid.velocity.x);

        if (speedx < this.maxMoveSpeed)
        {
            this.rigid.AddForce(transform.right * key * this.moveForce);
        }

	
    }
void OnTriggerEnter(Collider other)
	{
		Debug.Log("ゴール");
SceneManager.LoadScene("ClearScene");
	}
}