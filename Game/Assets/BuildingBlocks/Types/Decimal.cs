using UnityEngine;
using System.Collections;

public class Decimal : MonoBehaviour, IType
{
    #region Fields

    #endregion

    #region Properties

    public float? Value { get; set; }

    #endregion

    #region Methods

    public bool Compile() { return Value != null; }

    #endregion
}