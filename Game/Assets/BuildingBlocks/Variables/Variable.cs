using UnityEngine;
using System.Collections;

public class Variable : MonoBehaviour,IVariable
{
    #region Fields

    #endregion

    #region Properties

    public IType Value { get; set; }

    #endregion

    #region Methods

    public bool Compile() { return true; }

    #endregion
}
