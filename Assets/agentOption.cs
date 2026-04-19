using UnityEngine;

public class agentOption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] bool correct;
    [SerializeField] GameObject hover;
    void Start()
    {
        hover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (correct) Debug.Log("yay");
        else Debug.Log("no");
    }

    private void OnMouseOver()
    {
        if (!hover.activeSelf) hover.SetActive(true);
    }

    private void OnMouseExit()
    {
        if (hover.activeSelf) hover.SetActive(false);
    }
}
