using UnityEngine;

public class secret : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "vision") gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<ParticleSystem>().Play();
        Debug.Log("meow");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "vision") gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<ParticleSystem>().Stop();
    }

}
