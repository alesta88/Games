using UnityEngine;
using UnityEditor;

abstract class AbsPl : MonoBehaviour

{
    public string hello()
    {
        return "私はです。\n";
    }
    public abstract string action();
}