using System;
using System.Reflection;
using g8T6n6RbLPwmR1ScAJ;

namespace zN5BRFXsq596jZOTf5;

internal class eBAeUnDesS152cY3JS
{
	internal delegate void SFU4mbT3GMret7THonf(object o);

	internal static Module eBADeUnes;

	internal static void nC2MbxJf4(int typemdt)
	{
		Type type = eBADeUnes.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)eBADeUnes.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public eBAeUnDesS152cY3JS()
	{
		dil2BPgckjnUlJwuku.UrZapk9nD();
		base._002Ector();
	}

	static eBAeUnDesS152cY3JS()
	{
		dil2BPgckjnUlJwuku.UrZapk9nD();
		eBADeUnes = typeof(eBAeUnDesS152cY3JS).Assembly.ManifestModule;
	}
}
