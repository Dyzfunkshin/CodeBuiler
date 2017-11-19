using UnityEngine;
using System.Collections;

public class Boolean : MonoBehaviour, IType 
{
    #region Fields

    #endregion

    #region Properties

    public bool? Value { get; set; }

    #endregion

    #region Methods

    public bool Compile() { return Value != null; }

    #endregion
}