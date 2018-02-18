﻿using Antlr4.Runtime;
using Microsoft.Pc.TypeChecker.Types;

namespace Microsoft.Pc.TypeChecker.AST.Declarations
{
    public class Implementation : IPDecl
    {
        public Implementation(ParserRuleContext sourceNode, string name)
        {
            Name = name;
            SourceLocation = sourceNode;
        }

        public IPModuleExpr ModExpr { get; set; }
        public string Name { get; }
        public ParserRuleContext SourceLocation { get; }
    }
}