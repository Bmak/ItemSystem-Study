using UnityEngine;
using System.Collections;

namespace ItemSystem
{
    public interface IISStacable
    {
        int StackSize(int amount);  //default value of 0
        int MaxStack { get; }
    }
}

