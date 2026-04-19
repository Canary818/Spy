using UnityEngine;

public class lockButton : MonoBehaviour
{
    [SerializeField] public int inputVal;
    [SerializeField] ComboLock comboLock;
    private Color color;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        color = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        comboLock.getInput(inputVal);
    }

    private void OnMouseOver()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }

    private void OnMouseExit()
    {
        gameObject.GetComponent<SpriteRenderer>().color = color;
    }
}
