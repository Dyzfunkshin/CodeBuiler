using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class If : MonoBehaviour, IExecutor
{
	#region Fields

	public IBuildingBlock comparer;

	public List<IExecutable> ifExecutables;

	public List<IExecutable> elseExecutables;

	#endregion

	public void Execute()
	{
		if(IfCheck())
		{
			if (ifExecutables != null) 
			{
				foreach (IExecutable executable in ifExecutables) 
				{
					executable.Execute ();
				}
			}
		}
		else
		{
			if (elseExecutables != null) 
			{
				foreach (IExecutable executable in elseExecutables) 
				{
					executable.Execute ();
				}
			}
		}
	}

	public bool Compile()
	{
		return ComparerCompile () && IfExecutablesCompile () && ElseExecutablesCompile ();
	}

	public bool IfCheck()
	{
		if (comparer == null) 
		{
			return false;
		}

		IComparison c = comparer as IComparison;
		if (c != null) 
		{
			return c.Evaluate ();
		}

		IVariable v = comparer as IVariable;
		if (v != null) 
		{
			return (bool)v.Value;
		}

		IFunction f = comparer as IFunction;
		if (f != null) 
		{
			f.Execute ();
			return (bool)f.ReturnValue;
		}

		return false;
	}

	public bool ComparerCompile()
	{
		if (comparer == null) 
		{
			return false;
		}

		IComparison c = comparer as IComparison;
		if (c != null) 
		{
			return c.Compile ();
		}

		IVariable v = comparer as IVariable;
		if (v != null) 
		{
			return v.Compile () && v.Type is Boolean;
		}

		IFunction f = comparer as IFunction;
		if (f != null) 
		{
			return f.Compile () && f.ReturnType is Boolean;
		}

		return false;
	}

	public bool IfExecutablesCompile()
	{
		if (ifExecutables == null) 
		{
			return true;
		}

		foreach (IExecutable executable in ifExecutables) 
		{
			if (!executable.Compile ()) 
			{
				return false;
			}
		}

		return true;
	}

	public bool ElseExecutablesCompile()
	{
		if (elseExecutables == null) 
		{
			return true;
		}

		foreach (IExecutable executable in elseExecutables) 
		{
			if (!executable.Compile ()) 
			{
				return false;
			}
		}

		return true;
	}
}