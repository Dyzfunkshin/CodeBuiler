using UnityEngine;
using System.Collections;

public class Integer : MonoBehaviour, IType
{
    #region Fields

    #endregion

    #region Properties

    public int? Value { get; set; }

    #endregion

    #region Methods

    public bool Compile() { return Value != null; }

    #endregion
}