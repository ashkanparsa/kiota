﻿using System;
using Kiota.Builder.CodeDOM;

namespace Kiota.Builder.Writers.TypeScript;
public class CodeBlockEndWriter : BaseElementWriter<BlockEnd, TypeScriptConventionService>
{
    public CodeBlockEndWriter(TypeScriptConventionService conventionService) : base(conventionService)
    {
    }
    public override void WriteCodeElement(BlockEnd codeElement, LanguageWriter writer)
    {
        ArgumentNullException.ThrowIfNull(codeElement);
        ArgumentNullException.ThrowIfNull(writer);
        if (codeElement.Parent is CodeNamespace or CodeEnum) return;
        writer.CloseBlock();
        if (codeElement.Parent?.Parent is CodeNamespace)
            conventions.WriteAutoGeneratedEnd(writer);
    }
}
