using UnityEngine;

public abstract class UsableItem : ScriptableObject
{
    public Sprite Icon;

    public abstract void Use();
}