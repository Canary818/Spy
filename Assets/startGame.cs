using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        transform.localScale = new Vector3 (transform.localScale.x + 0.1f, transform.localScale.y + 0.1f, transform.localScale.z);
    }

    private void OnMouseExit()
    {
        transform.localScale = new Vector3(transform.localScale.x - 0.1f, transform.localScale.y - 0.1f, transform.localScale.z);
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
