using Unity.VisualScripting;
using UnityEngine;


public class AgentPaper1 : MonoBehaviour
{
    [SerializeField] GameObject nextPage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        nextPage.SetActive(true);
        
    }
}
