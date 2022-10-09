using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            RightArrow();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            LeftArrow();
        }
    }
    private void RightArrow()
    {
        if (transform.position.z != 2)
        {
            transform.position = new Vector3(0, 0, transform.position.z + 2);
        }
       
    }

    private void LeftArrow()
    {
        if (transform.position.z != -2)
        {
            transform.position = new Vector3(0, 0, transform.position.z - 2);
        }
    }
    private void OnCollisionEnter(Collision enemy)
    {
        if (enemy.collider.GetComponent<MovementEnemy>())
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(2);
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            ScoreChek.api.GetScore();
        }

    }
}
