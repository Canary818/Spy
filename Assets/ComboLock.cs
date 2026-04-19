using UnityEngine;

public class ComboLock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int[] inputCombo = {0, 0, 0, 0, 0};
    private int[] answer = {1, 2, 4, 1, 3};
    private int inputCount = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getInput(int input)
    {
        inputCombo[inputCount] = input;
        inputCount++;
        if (inputCount < 5) if (!check()) Reset();
        if (inputCount == 5) if (check()) complete(); else Reset();

    }

    bool check()
    {
        return (inputCombo[inputCount - 1] == answer[inputCount - 1]);
    }

    private void Reset()
    {
        for (int i = 0; i < inputCombo.Length; i++) inputCombo[i] = 0;
    }

    void complete()
    {

    }
}
