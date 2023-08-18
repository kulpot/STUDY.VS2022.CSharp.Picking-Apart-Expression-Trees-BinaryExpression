using System;
using System.Linq.Expressions;

//ref link:https://www.youtube.com/watch?v=TFRQEwMSiIM&list=PLRwVmtr-pp06SlwcsqhreZ2byuozdnPlg&index=8
//  lambda expression vs compiler converter lambda method


class MainClass
{
    //static bool msilLambdaCompilerVersion(int i)
    //{
    //    return i > 5;
    //}
    static void Main()
    {
        Expression<Func<int, bool>> test = i => i > 5;

        ConstantExpression constExp = Expression.Constant(5, typeof(int));
        ParameterExpression iParam = Expression.Parameter(typeof(int), "i");
        BinaryExpression greaterThan = Expression.GreaterThan(iParam, constExp);


        //ConstantExpression constExp = Expression.Constant(5, typeof(int));
        //Console.WriteLine(constExp.NodeType);
        //Console.WriteLine(constExp.Type);
        //Console.WriteLine(constExp.Value);

        //ParameterExpression iParam = Expression.Parameter(typeof(int), "i");
        //Console.WriteLine(iParam.NodeType);
        //Console.WriteLine(iParam.Type);
        //Console.WriteLine(iParam.Name);

        // > >= < <= + - ==    // BinaryExpression

        //BinaryExpression greaterThan = Expression.GreaterThan(iParam, constExp);
        //Console.WriteLine(greaterThan.NodeType);
        //Console.WriteLine(greaterThan.Type);
        //Console.WriteLine(greaterThan.Left);
        //Console.WriteLine(greaterThan.Right);



        //Expression<Func<int, bool>> test = msilLambdaCompilerVersion; // error: Expression requires lambda
        // Original lambda:

        //Expression<Func<int, bool>> exp = i => i > 5;

        // What the compiler did:
        //ParameterExpression expression3;
        //Expression<Func<int, bool>> expression =
        //    Expression.Lambda<Func<int, bool>>(
        //        Expression.GreaterThan(
        //            expression3 = Expression.Parameter(
        //                typeof(int), "i"),
        //                Expression.Constant(5, typeof(int))),
        //                new ParameterExpression[] { expression3 });

        //Console.WriteLine(exp.Body.GetType());
        //BinaryExpression binary = (BinaryExpression)exp.Body;
        //Console.WriteLine(binary.Left);
        //Console.WriteLine(binary.NodeType);
        //Console.WriteLine(binary.Right);



        //Func<int, bool> test = i => i > 5;
        //Func<int, bool> test2 = msilLambdaCompilerVersion;
        //Console.WriteLine(test(3)); // 3 greater than 5 is false
        //Console.WriteLine(test(8)); // 8 > 5 is true
        //Console.WriteLine(test2(3));
        //Console.WriteLine(test2(8));
    }
}