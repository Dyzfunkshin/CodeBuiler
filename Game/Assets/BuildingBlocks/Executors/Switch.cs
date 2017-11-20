using UnityEngine;
using System.Collections.Generic;

public class Switch : MonoBehaviour, IExecutor
{
    #region Constants

    #endregion

    #region Fields

    public IType switchValueType;

    public List<Case> cases;

    #endregion

    #region Properties

    #endregion

    #region Unity Overrides

    #endregion

    #region Methods

    public void Execute()
    {
        if (switchValueType == null || cases == null)
            return;

        Boolean switchTypeBoolean = TryTypeBoolean();
        Decimal switchTypeDecimal = TryTypeDecimal();
        Integer switchTypeInteger = TryTypeInteger();
        String switchTypeString = TryTypeString();

        foreach (Case _case in cases)
        {
            if (switchTypeBoolean != null)
            {
                Boolean val = _case.caseValue as Boolean;

                if (val != null && val.Value == switchTypeBoolean.Value)
                {
                    _case.Execute();
                    return;
                }
            }
            else if (switchTypeDecimal != null && switchTypeDecimal.Value != null)
            {
                Decimal val = _case.caseValue as Decimal;

                if (val != null && 
                    val.Value != null && 
                    Mathf.Approximately(val.Value.Value, switchTypeDecimal.Value.Value))
                {
                    _case.Execute();
                    return;
                }
            }
            else if (switchTypeInteger != null)
            {
                Integer val = _case.caseValue as Integer;

                if (val != null && val.Value == switchTypeInteger.Value)
                {
                    _case.Execute();
                    return;
                }
            }
            else if (switchTypeString != null)
            {
                String val = _case.caseValue as String;

                if (val != null && val.Value == switchTypeString.Value)
                {
                    _case.Execute();
                    return;
                }
            }

            _case.Execute();
        }
    }

    public bool Compile()
    {
        if (switchValueType == null || cases == null)
            return false;

        return CompileCases();
    }

    private bool CompileCases()
    {
        Boolean switchTypeBoolean = TryTypeBoolean();
        Decimal switchTypeDecimal = TryTypeDecimal();
        Integer switchTypeInteger = TryTypeInteger();
        String switchTypeString = TryTypeString();

        foreach (Case _case in cases)
        {
            if (switchTypeBoolean != null)
            {
                Boolean val = _case.caseValue as Boolean;
                if (val == null)
                    return false;
            }
            else if (switchTypeDecimal != null)
            {
                Decimal val = _case.caseValue as Decimal;
                if (val == null)
                    return false;
            }
            else if (switchTypeInteger != null)
            {
                Integer val = _case.caseValue as Integer;
                if (val == null)
                    return false;
            }
            else if (switchTypeString != null)
            {
                String val = _case.caseValue as String;
                if (val == null)
                    return false;
            }
        }

        return true;
    }

    private Boolean TryTypeBoolean()
    {
        return switchValueType as Boolean;
    }

    private Decimal TryTypeDecimal()
    {
        return switchValueType as Decimal;
    }

    private Integer TryTypeInteger()
    {
        return switchValueType as Integer;
    }

    private String TryTypeString()
    {
        return switchValueType as String;
    }

    #endregion
}