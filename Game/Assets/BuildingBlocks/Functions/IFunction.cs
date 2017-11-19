using UnityEngine;
using System.Collections;

public interface IFunction : IExecutable 
{
	IType ReturnType{ get; set; }

	object ReturnValue{ get; set; }
}
