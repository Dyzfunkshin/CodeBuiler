using UnityEngine;
using System.Collections;

public class Variable : MonoBehaviour,IVariable
{
    #region Fields

    #endregion

    #region Properties

    public object Value { get; set; }

	public IType Type{ get; set; }

    #endregion

    #region Methods

    public bool Compile() { return true; }

    #endregion
}
