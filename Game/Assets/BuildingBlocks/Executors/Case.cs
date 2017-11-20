using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour, IExecutor
{
    #region Constants

    #endregion

    #region Fields

    public IType caseValue;

    public List<IExecutable> executables;

    #endregion

    #region Properties

    #endregion

    #region Methods

    public bool Compile()
    {
        if (executables == null || caseValue == null)
            return false;

        foreach (IExecutable exec in executables)
            if (!exec.Compile())
                return false;

        return true;
    }

    public void Execute()
    {
        if (executables == null)
            return;

        foreach (IExecutable executable in executables)
            executable.Execute();
    }

    #endregion
}