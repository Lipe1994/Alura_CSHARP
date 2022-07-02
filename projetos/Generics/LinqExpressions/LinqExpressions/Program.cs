using System;
using System.Linq.Expressions;

namespace LinqExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<float, float> metade = quo => quo / 2;
            Console.WriteLine("Metade de 9 é {0}", metade(9));


            //TAREFA: Recriar a Função acima, 
            //porém usando árvore de expressões LINQ

            //1) Criar as expressões individuais
            ParameterExpression quociente = Expression.Parameter(typeof(float), "quo");

            ConstantExpression divisor = Expression.Constant(2f, typeof(float));

            BinaryExpression opDivisao = Expression.Divide(quociente, divisor);

            //2) Criar a árvore de expressões
            Expression<Func<float, float>> exprMetade = Expression.Lambda<Func<float, float>>(opDivisao, new ParameterExpression[] { quociente });


            //3) Compilar e executar o código
            var metadeCompilada = exprMetade.Compile();
            Console.WriteLine($"Metade de 16 é : {metade(16)}");






            //4) Modificar a árvore de expressões
            TrocarDivisaoPorMultiplicacao trocarDivisaoPorMultiplicacao = new TrocarDivisaoPorMultiplicacao();

            Expression<Func<float, float>> exprMultiply = (Expression<Func<float, float>>) trocarDivisaoPorMultiplicacao.visit(exprMetade);

            var exprMultiplicacaoCompilada = exprMultiply.Compile();

            Console.WriteLine($"O resultado da multiplicação é(30X2) {exprMultiplicacaoCompilada(30)}");

        }

        class TrocarDivisaoPorMultiplicacao : ExpressionVisitor 
        {
            public Expression visit(Expression expression) 
            {
                return Visit(expression);
            }

            protected override Expression VisitBinary(BinaryExpression node) 
            {
                if(node.NodeType == ExpressionType.Divide) 
                {
                    return Expression.Multiply(node.Left, node.Right);
                }

                return base.VisitBinary(node);
            }
        }
    }
}
