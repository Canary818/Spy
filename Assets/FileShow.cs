using UnityEngine;

public class FileShow : MonoBehaviour
{
    [SerializeField] GameObject normal;
    [SerializeField] GameObject secret;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        normal.SetActive(false);
        secret.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Cat") 
        {
            normal.SetActive(true);
            secret.SetActive(true);
            secret.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
         }
    }
}
