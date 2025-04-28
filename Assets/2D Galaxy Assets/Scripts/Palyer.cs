using UnityEngine;

public class Palyer : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    //public float horizontalInput;
    //public float verticalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 vet = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement(){
              // Translação Horizontal
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        // Translação Vertical
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * speed * verticalInput * Time.deltaTime);

        //Restringir o movimento em Y
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        //Restringir o movimento em X   
        /*
        if(transform.position.x > 8.2f){
            transform.position = new Vector3(8.2f, transform.position.y, 0);
        }else if(transform.position.x < -8.2){
            transform.position = new Vector3(-8.2f, transform.position.y, 0);
        }
        */

        //Movimento com Wrapping (Teletransporte nas Bordas) no Unity
        if (transform.position.y > 0)
        {
            transform.position = new Vector3(transform.position.x, 0, 0);
        }
        else if (transform.position.y < -4.2f)
        {
            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        if (transform.position.x > 9.5f)
        {
            transform.position = new Vector3(-9.5f, transform.position.y, 0);
        }
        else if (transform.position.x < -9.5f)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }
    }
}
