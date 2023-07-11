using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject b = GameObject.Instantiate(bullet);
            b.GetComponent<Rigidbody>().velocity = Vector3.right*60;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Scores");
        }
    }

}
