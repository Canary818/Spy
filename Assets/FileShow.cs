using UnityEngine;

public class FileShow : MonoBehaviour
{
    [SerializeField] GameObject normal;
    [SerializeField] GameObject secret;
    private float min;
    private float max;
  
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.y - 0.1f;
        max = transform.position.y + 0.3f;
        transform.position = new Vector3(transform.position.x, Random.Range(min, max), 0);
        normal.SetActive(false);
        secret.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 0.6f, max - min) + min, transform.position.z);
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
