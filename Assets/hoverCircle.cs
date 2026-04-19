using UnityEngine;

public class hoverCircle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}
