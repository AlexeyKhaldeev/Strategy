using UnityEngine;


public sealed class WaitForKey : CustomYieldInstruction
{
    private readonly KeyCode _key;

    public override bool keepWaiting => !Input.GetKeyDown(_key);    
    public WaitForKey(KeyCode key)
    {
        _key = key;
    }
}
