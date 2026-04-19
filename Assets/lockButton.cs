using UnityEngine;

public class lockButton : MonoBehaviour
{
    [SerializeField] public int inputVal;
    [SerializeField] ComboLock comboLock;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(inputVal);
        comboLock.getInput(inputVal);
    }
}
