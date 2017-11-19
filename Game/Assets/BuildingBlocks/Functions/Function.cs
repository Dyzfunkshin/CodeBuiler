using UnityEngine;
using System.Collections;

public class Function : MonoBehaviour, IFunction
{
    #region Constants

    #endregion

    #region Fields

    #endregion

    #region Properties

	public IType ReturnType{ get; set; }

	public object ReturnValue{ get; set; }

    #endregion

    #region Unity Overrides

    #endregion

    #region Methods

    public void Execute() { }

    public bool Compile() { return true; }

    #endregion
}