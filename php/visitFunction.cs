using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime.Misc;

namespace php
{
    class visitFunction : phpBaseListener {

        phpParser.FunctionBodyContext fc;

        public override void EnterFunctionDec([NotNull] phpParser.FunctionDecContext context)
        {

            if (context.b)
            {
                fc = context.functionBody();
                phpParser.Function func = new phpParser.Function();

                func.name = context.LABEL().GetText();
                func.returnType = context.functionBody().functionBodyReturnType;
                func.parameterCount = phpParser.functionParams.Count;

                phpParser.Variable functionVar = new phpParser.Variable();

                foreach (string parName in phpParser.functionParams)
                {
                    functionVar.name = parName;
                    func.parameterNames.Add(new phpParser.Variable { name = parName });
                }

                phpParser.functionParams = new List<string>();

                phpParser.functions.Add(func);
            }
            //print(String.Format("{0} {1}:\t{2}\n", func.returnType, func.name, func.parameterCount));
        }

        public override void EnterFunctionCall([NotNull] phpParser.FunctionCallContext context)
        {
            if (context.b)
            {
                fc.b = true;
                int i = 0;

                foreach (phpParser.Function f in phpParser.functions)
                {
                    if (f.name == context.functionName().GetText() && f.parameterCount == phpParser.functionArgs.Count)
                    {

                        break;
                    }
                    i++;
                }

                for (int j = 0; j < phpParser.functionArgs.Count; j++)
                {
                    string[] parts = phpParser.functionArgs[j].Split(':');

                    phpParser.functions[i].parameterNames[j].type = parts[0];
                    phpParser.functions[i].parameterNames[j].value = parts[1];
                    phpParser.functions[i].arguments.Add(parts[1]);
                    //print(parts[0] + " " + parts[1] "\n");

                    phpParser.vars.Add(new phpParser.Variable { name = phpParser.functions[i].parameterNames[j].name, type = parts[0], value = parts[1] });

                    //print(functions[i].parameterNames[j].name + " " + functions[i].parameterNames[j].value + "\n");
                }



                foreach (phpParser.Variable v in phpParser.vars)
                {
                    Console.Write(String.Format("{0} {1} = {2}\n", v.type, v.name, v.value));
                }

                phpParser.functionArgs = new List<string>();
            }
            base.EnterFunctionBody(fc);
        }
    }
}
