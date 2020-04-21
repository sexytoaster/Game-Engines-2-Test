using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    public virtual IEnumerator Green()
    {
        yield break;
    }
    public virtual IEnumerator Yellow()
    {
        yield break;
    }
    public virtual IEnumerator Red()
    {
        yield break;
    }
}
