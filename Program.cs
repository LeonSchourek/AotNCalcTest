using System.Diagnostics.CodeAnalysis;

using AotNCalcTest;

using NCalc;

internal class Program
{
	//[DynamicDependency(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicProperties, typeof(IDiscountProductGroupData))]
	private static void Main(string[] args)
	{
		ProductpData p = new ProductpData(1900, 0.19f);
		string expr = "[FullPrice]-([Price]*0.9*(1+[Mwst]))";
		NCalc.Expression exp = new Expression(expr);
		if (exp.HasErrors())
		{
			throw exp.Error;
		}

		exp.Options = ExpressionOptions.OverflowProtection | ExpressionOptions.DecimalAsDefault;
		Console.WriteLine(Create1<ProductpData>(exp)(p));
	}

	private static Func<T, ulong> Create0<T>(Expression exp) => exp.ToLambda<T, ulong>();

	private static Func<T, ulong> Create1<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields | DynamicallyAccessedMemberTypes.PublicProperties)] T>(Expression exp) => exp.ToLambda<T, ulong>();
}