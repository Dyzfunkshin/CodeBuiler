using UnityEngine;
using System.Collections;

public class String : MonoBehaviour, IType
{
    #region Fields

    #endregion

    #region Properties

    public string Value { get; set; }

    #endregion

    #region Methods

    public bool Compile() { return Value != null; }

    #endregion
}